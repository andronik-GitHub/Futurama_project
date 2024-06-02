using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.Services;
using GalaxyExpress.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GalaxyExpress.API.Controllers
{
    /// <summary>
    /// PhoneNumber controller
    /// </summary>
    [Produces("application/json")]
    [Route("galaxy-express/[controller]")]
    [ApiController]
    public class PhoneNumberController : ControllerBase
    {
        private readonly IPhoneNumberService _phoneNumberService;
        private readonly ILogger _logger;
        private readonly string _tableName;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="phoneNumberService">PhoneNumber service</param>
        /// <param name="loggerFactory">PhoneNumber logger factory</param>
        public PhoneNumberController(IPhoneNumberService phoneNumberService, ILoggerFactory loggerFactory)
        {
            _phoneNumberService = phoneNumberService;
            _logger = loggerFactory.CreateLogger($"{this.GetType().Name}_Logger");
            _tableName = this.GetType().Name.Replace("Controller", "") + "s";
        }


        #region CRUD


        /// <summary>
        /// Gets the list of all PhoneNumbers
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/phoneNumber
        /// </remarks>
        /// <returns>Returns list of GetDTO_PhoneNumber</returns>
        /// <response code="200">Success</response>
        /// <response code="500">If it was not possible to get a list of elements from the database</response>
        [HttpGet(Name = nameof(GetAllPhoneNumbersAsync))] // GET: galaxy-express/phoneNumber
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetDTO_PhoneNumber>>> GetAllPhoneNumbersAsync()
        {
            try
            {
                var collection = (await _phoneNumberService.GetAllAsync()).ToList();
                _logger.LogInformation
                    ("{Count} entities were successfully extracted from [{Table}]", collection.Count, _tableName);

                return Ok(collection);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetAllPhoneNumbersAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Gets the PhoneNumber by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/phoneNumber/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">PhoneNumber id (Guid)</param>
        /// <returns>Returns element of GetDTO_PhoneNumber</returns>
        /// <response code="200">Success</response>
        /// <response code="404">If the element with such ID is not found in the database</response>
        /// <response code="500">If it was not possible to get element from the database</response>
        [HttpGet("{id:guid}", Name = nameof(GetPhoneNumberByIdAsync))] // GET: galaxy-express/phoneNumber/id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDTO_PhoneNumber>> GetPhoneNumberByIdAsync(Guid id)
        {
            try
            {
                var entity = await _phoneNumberService.GetAsync(id);
                if (entity == null)
                {
                    _logger.LogError("Entity with id: [{EntityId}] from [{Table}] not found", id, _tableName);
                    return StatusCode(StatusCodes.Status404NotFound);
                }


                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully extracted from [{Table}]", id, _tableName);

                return Ok(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetPhoneNumberByIdAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Creates new PhoneNumber
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: galaxy-express/phoneNumber
        ///     {
        ///         "number": "string",
        ///         "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///     }
        /// </remarks>
        /// <param name="newEntity">InsertDTO_PhoneNumber newEntity</param>
        /// <returns>Returns id (Guid)</returns>
        /// <response code="200">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPost(Name = nameof(AddPhoneNumberAsync))] // POST: galaxy-express/phoneNumber
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Guid>> AddPhoneNumberAsync(InsertDTO_PhoneNumber newEntity)
        {
            try
            {
                var id = await _phoneNumberService.CreateAsync(newEntity);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully added to [{Table}]", id, _tableName);

                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(AddPhoneNumberAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Update the PhoneNumber
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT: galaxy-express/phoneNumber
        ///     {
        ///         "phoneNumberId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///         "number": "string",
        ///         "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///     }
        /// </remarks>
        /// <param name="updateEntity">UpdateDTO_PhoneNumber updateEntity</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPut(Name = nameof(UpdatePhoneNumberAsync))] // PUT: galaxy-express/phoneNumber
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdatePhoneNumberAsync(UpdateDTO_PhoneNumber updateEntity)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _phoneNumberService.GetAsync(updateEntity.PhoneNumberId);
                if (findResult == null)
                {
                    _logger.LogError
                        ("Entity with id: [{EntityId}] from [{Table}] not found", updateEntity.PhoneNumberId, _tableName);

                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _phoneNumberService.UpdateAsync(updateEntity);
                _logger.LogInformation(
                    "Entity with id: [{EntityId}] were successfully updated from [{Table}]",
                    updateEntity.PhoneNumberId, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(UpdatePhoneNumberAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Delete the PhoneNumber by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// DELETE: galaxy-express/phoneNumber/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">PhoneNumber id (Guid)</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpDelete("{id:guid}", Name = nameof(DeletePhoneNumberAsync))] // DELETE: galaxy-express/phoneNumber/id
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeletePhoneNumberAsync(Guid id)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _phoneNumberService.GetAsync(id);
                if (findResult == null)
                {
                    _logger.LogError("Entity with id: [{EntityId}] from [{Table}] not found", id, _tableName);
                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _phoneNumberService.DeleteAsync(id);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully deleted from [{Table}]", id, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(DeletePhoneNumberAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        #endregion
    }
}
