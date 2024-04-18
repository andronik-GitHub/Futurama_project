using GalaxyExpress.BLL.DTOs.PaymentCardDTOs;
using GalaxyExpress.BLL.Services;
using GalaxyExpress.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GalaxyExpress.API.Controllers
{
    /// <summary>
    /// paymentCard controller
    /// </summary>
    [Produces("application/json")]
    [Route("galaxy-express/[controller]")]
    [ApiController]
    public class PaymentCardController : ControllerBase
    {
        private readonly IPaymentCardService _paymentCardService;
        private readonly ILogger _logger;
        private readonly string _tableName;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="paymentCardService">PaymentCard service</param>
        /// <param name="loggerFactory">PaymentCard logger factory</param>
        public PaymentCardController(IPaymentCardService paymentCardService, ILoggerFactory loggerFactory)
        {
            _paymentCardService = paymentCardService;
            _logger = loggerFactory.CreateLogger($"{this.GetType().Name}_Logger");
            _tableName = this.GetType().Name.Replace("Controller", "") + "s";
        }


        #region CRUD


        /// <summary>
        /// Gets the list of all PaymentCards
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/paymentCard
        /// </remarks>
        /// <returns>Returns list of GetDTO_PaymentCard</returns>
        /// <response code="200">Success</response>
        /// <response code="500">If it was not possible to get a list of elements from the database</response>
        [HttpGet(Name = nameof(GetAllPaymentCardsAsync))] // GET: galaxy-express/paymentCard
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetDTO_PaymentCard>>> GetAllPaymentCardsAsync()
        {
            try
            {
                var collection = (await _paymentCardService.GetAllAsync()).ToList();
                _logger.LogInformation
                    ("{Count} entities were successfully extracted from [{Table}]", collection.Count, _tableName);

                return Ok(collection);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetAllPaymentCardsAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Gets the PaymentCard by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/paymentCard/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">PaymentCard id (Guid)</param>
        /// <returns>Returns element of GetDTO_PaymentCard</returns>
        /// <response code="200">Success</response>
        /// <response code="404">If the element with such ID is not found in the database</response>
        /// <response code="500">If it was not possible to get element from the database</response>
        [HttpGet("{id:guid}", Name = nameof(GetPaymentCardByIdAsync))] // GET: galaxy-express/paymentCard/id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDTO_PaymentCard>> GetPaymentCardByIdAsync(Guid id)
        {
            try
            {
                var entity = await _paymentCardService.GetAsync(id);
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
                    this.GetType().Name, nameof(GetPaymentCardByIdAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Creates new PaymentCard
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: galaxy-express/paymentCard
        ///     {
        ///         "paymentCard": "string",
        ///         "validity": "string",
        ///         "CVV": "string",
        ///         "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///     }
        /// </remarks>
        /// <param name="newEntity">InsertDTO_PaymentCard newEntity</param>
        /// <returns>Returns id (Guid)</returns>
        /// <response code="200">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPost(Name = nameof(AddPaymentCardAsync))] // POST: galaxy-express/paymentCard
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Guid>> AddPaymentCardAsync(InsertDTO_PaymentCard newEntity)
        {
            try
            {
                var id = await _paymentCardService.CreateAsync(newEntity);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully added to [{Table}]", id, _tableName);

                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(AddPaymentCardAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Update the PaymentCard
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT: galaxy-express/paymentCard
        ///     {
        ///         "PaymentCardId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///         "PaymentCardAddress": "string",
        ///         "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///     }
        /// </remarks>
        /// <param name="updateEntity">UpdateDTO_PaymentCard updateEntity</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPut(Name = nameof(UpdatePaymentCardAsync))] // PUT: galaxy-express/paymentCard
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdatePaymentCardAsync(UpdateDTO_PaymentCard updateEntity)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _paymentCardService.GetAsync(updateEntity.CardId);
                if (findResult == null)
                {
                    _logger.LogError
                        ("Entity with id: [{EntityId}] from [{Table}] not found", updateEntity.CardId, _tableName);

                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _paymentCardService.UpdateAsync(updateEntity);
                _logger.LogInformation(
                    "Entity with id: [{EntityId}] were successfully updated from [{Table}]",
                    updateEntity.CardId, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(UpdatePaymentCardAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// Delete the PaymentCard by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// DELETE: galaxy-express/paymentCard/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">PaymentCard id (Guid)</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpDelete("{id:guid}", Name = nameof(DeletePaymentCardAsync))] // DELETE: galaxy-express/paymentCard/id
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeletePaymentCardAsync(Guid id)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _paymentCardService.GetAsync(id);
                if (findResult == null)
                {
                    _logger.LogError("Entity with id: [{EntityId}] from [{Table}] not found", id, _tableName);
                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _paymentCardService.DeleteAsync(id);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully deleted from [{Table}]", id, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(DeletePaymentCardAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        #endregion
    }
}
