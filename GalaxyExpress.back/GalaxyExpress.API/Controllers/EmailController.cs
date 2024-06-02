using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GalaxyExpress.API.Controllers
{
    /// <summary>
    /// Email controller
    /// </summary>
    [Produces("application/json")]
    [Route("galaxy-express/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly ILogger _logger;
        private readonly string _tableName;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="emailService">Email service</param>
        /// <param name="loggerFactory">Email logger factory</param>
        public EmailController(IEmailService emailService, ILoggerFactory loggerFactory)
        {
            _emailService = emailService;
            _logger = loggerFactory.CreateLogger($"{this.GetType().Name}_Logger");
            _tableName = this.GetType().Name.Replace("Controller", "") + "s";
        }


        #region CRUD


        /// <summary>
        /// Gets the list of all Emails
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/email
        /// </remarks>
        /// <returns>Returns list of GetDTO_Email</returns>
        /// <response code="200">Success</response>
        /// <response code="500">If it was not possible to get a list of elements from the database</response>
        [HttpGet(Name = nameof(GetAllEmailsAsync))] // GET: galaxy-express/email
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetDTO_Email>>> GetAllEmailsAsync()
        {
            try
            {
                var collection = (await _emailService.GetAllAsync()).ToList();
                _logger.LogInformation
                    ("{Count} entities were successfully extracted from [{Table}]", collection.Count, _tableName);

                return Ok(collection);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetAllEmailsAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Gets the Email by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/email/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">Email id (Guid)</param>
        /// <returns>Returns element of GetDTO_Email</returns>
        /// <response code="200">Success</response>
        /// <response code="404">If the element with such ID is not found in the database</response>
        /// <response code="500">If it was not possible to get element from the database</response>
        [HttpGet("{id:guid}", Name = nameof(GetEmailByIdAsync))] // GET: galaxy-express/Email/id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDTO_Email>> GetEmailByIdAsync(Guid id)
        {
            try
            {
                var entity = await _emailService.GetAsync(id);
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
                    this.GetType().Name, nameof(GetEmailByIdAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Creates new Email
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: galaxy-express/email
        ///     {
        ///         "emailAddress": "string",
        ///         "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///     }
        /// </remarks>
        /// <param name="newEntity">InsertDTO_Email newEntity</param>
        /// <returns>Returns id (Guid)</returns>
        /// <response code="200">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPost(Name = nameof(AddEmailAsync))] // POST: galaxy-express/email
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Guid>> AddEmailAsync(InsertDTO_Email newEntity)
        {
            try
            {
                var id = await _emailService.CreateAsync(newEntity);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully added to [{Table}]", id, _tableName);

                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(AddEmailAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Update the Email
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT: galaxy-express/email
        ///     {
        ///         "emailId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///         "emailAddress": "string",
        ///         "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///     }
        /// </remarks>
        /// <param name="updateEntity">UpdateDTO_Email updateEntity</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPut(Name = nameof(UpdateEmailAsync))] // PUT: galaxy-express/email
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateEmailAsync(UpdateDTO_Email updateEntity)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _emailService.GetAsync(updateEntity.EmailId);
                if (findResult == null)
                {
                    _logger.LogError
                        ("Entity with id: [{EntityId}] from [{Table}] not found", updateEntity.EmailId, _tableName);

                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _emailService.UpdateAsync(updateEntity);
                _logger.LogInformation(
                    "Entity with id: [{EntityId}] were successfully updated from [{Table}]",
                    updateEntity.EmailId, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(UpdateEmailAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Delete the Email by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// DELETE: galaxy-express/email/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">Email id (Guid)</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpDelete("{id:guid}", Name = nameof(DeleteEmailAsync))] // DELETE: galaxy-express/email/id
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEmailAsync(Guid id)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _emailService.GetAsync(id);
                if (findResult == null)
                {
                    _logger.LogError("Entity with id: [{EntityId}] from [{Table}] not found", id, _tableName);
                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _emailService.DeleteAsync(id);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully deleted from [{Table}]", id, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(DeleteEmailAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        #endregion
    }
}
