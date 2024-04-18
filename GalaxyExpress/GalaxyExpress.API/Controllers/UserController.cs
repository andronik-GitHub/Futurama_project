using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GalaxyExpress.API.Controllers
{
    /// <summary>
    /// User controller
    /// </summary>
    [Produces("application/json")]
    [Route("galaxy-express/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger _logger;
        private readonly string _tableName;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="userService">User service</param>
        /// <param name="loggerFactory">User logger factory</param>
        public UserController(IUserService userService, ILoggerFactory loggerFactory)
        {
            _userService = userService;
            _logger = loggerFactory.CreateLogger($"{this.GetType().Name}_Logger");
            _tableName = this.GetType().Name.Replace("Controller", "") + "s";
        }


        #region CRUD



        /// <summary>
        /// Gets the list of all Users
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/user
        /// </remarks>
        /// <returns>Returns list of GetDTO_User</returns>
        /// <response code="200">Success</response>
        /// <response code="500">If it was not possible to get a list of elements from the database</response>
        [HttpGet(Name = nameof(GetAllUsersAsync))] // GET: galaxy-express/user
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetDTO_User>>> GetAllUsersAsync()
        {
            try
            {
                var collection = (await _userService.GetAllAsync()).ToList();
                _logger.LogInformation
                    ("{Count} entities were successfully extracted from [{Table}]", collection.Count, _tableName);

                return Ok(collection);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetAllUsersAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Gets the User by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/user/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">User id (Guid)</param>
        /// <returns>Returns element of GetDTO_User</returns>
        /// <response code="200">Success</response>
        /// <response code="404">If the element with such ID is not found in the database</response>
        /// <response code="500">If it was not possible to get element from the database</response>
        [HttpGet("{id:guid}", Name = nameof(GetUserByIdAsync))] // GET: galaxy-express/user/id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDTO_User>> GetUserByIdAsync(Guid id)
        {
            try
            {
                var entity = await _userService.GetAsync(id);
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
                    this.GetType().Name, nameof(GetUserByIdAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Creates new User
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: galaxy-express/user
        ///     {
        ///         "login": "string",
        ///         "firstName": "string",
        ///         "lastName": "string",
        ///         "password": "string",
        ///         "fatherName": "string",
        ///         "birthday": "2024-04-11T09:47:23.592Z",
        ///         "sex": "string"
        ///     }
        /// </remarks>
        /// <param name="newEntity">InsertDTO_User newEntity</param>
        /// <returns>Returns id (Guid)</returns>
        /// <response code="200">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPost(Name = nameof(AddUserAsync))] // POST: galaxy-express/user
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Guid>> AddUserAsync(InsertDTO_User newEntity)
        {
            try
            {
                // Checking whether valid data has been entered
                if (newEntity?.FirstName == null || newEntity?.LastName == null ||
                    newEntity?.Login == null || newEntity?.Password == null)
                {
                    _logger.LogError("Invalid data entered");
                    return StatusCode(StatusCodes.Status400BadRequest);
                }


                var id = await _userService.CreateAsync(newEntity);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully added to [{Table}]", id, _tableName);

                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(AddUserAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Update the User
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT: galaxy-express/user
        ///     {
        ///         "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        ///         "values":
        ///         {
        ///             "Login": "string",
        ///             "FirstName": "string",
        ///             ...
        ///             "AdditionalPropN": "string",
        ///         }
        ///     }
        /// </remarks>
        /// <param name="upEntity">UpdateDTO_User updateEntity</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpPut(Name = nameof(UpdateUserAsync))] // PUT: galaxy-express/user
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateUserAsync([FromBody] UpdateDTO_User upEntity)
        {
            try
            {
                // Checking whether valid data has been entered
                if (upEntity.Values.Count <= 0)
                {
                    _logger.LogError("Invalid data entered");
                    return StatusCode(StatusCodes.Status400BadRequest);
                }


                // Whether there is such a record in the database at all
                var findResult = await _userService.GetAsync(upEntity.UserId);
                if (findResult == null)
                {
                    _logger.LogError
                        ("Entity with id: [{EntityId}] from [{Table}] not found", upEntity.UserId, _tableName);

                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _userService.UpdateAsync(upEntity);
                _logger.LogInformation
                ("Entity with id: [{EntityId}] were successfully updated from [{Table}]",
                    upEntity.UserId, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(UpdateUserAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Delete the User by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// DELETE: galaxy-express/user/13ce1333-7b7c-4395-8565-0474a6ad05ad
        /// </remarks>
        /// <param name="id">User id (Guid)</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">Success</response>
        /// <response code="400">If invalid data entered</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpDelete("{id:guid}", Name = nameof(DeleteUserAsync))] // DELETE: galaxy-express/user/id
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteUserAsync(Guid id)
        {
            try
            {
                // Whether there is such a record in the database at all
                var findResult = await _userService.GetAsync(id);

                if (findResult == null)
                {
                    _logger.LogError("Entity with id: [{EntityId}] from [{Table}] not found", id, _tableName);
                    return StatusCode(StatusCodes.Status404NotFound);
                }


                await _userService.DeleteAsync(id);
                _logger.LogInformation
                    ("Entity with id: [{EntityId}] were successfully deleted from [{Table}]", id, _tableName);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(DeleteUserAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        #endregion

        #region EXTENSIONS


        /// <summary>
        /// Get count of entities in table Users, including deleted ones
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/user/count-with-delete
        /// </remarks>
        /// <returns>Count of entities in table Users, including deleted ones</returns>
        /// <response code="200">Success</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpGet("count-with-delete", Name = nameof(GetCountOfUsersAsync))] // GET: galaxy-express/count-with-delete
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> GetCountOfUsersAsync()
        {
            try
            {
                var count = await _userService.GetCountOfUsersAsync();
                _logger.LogInformation("{Count} entities are present in [{Table}], including deleted ones", count, _tableName);

                return Ok(count);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetCountOfUsersAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Get count of entities in table Users
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET galaxy-express/user/count
        /// </remarks>
        /// <returns>Count of entities in table Users</returns>
        /// <response code="200">Success</response>
        /// <response code="500">If it was not possible to adding element to the database</response>
        [HttpGet("count", Name = nameof(GetCountOfUsersNotDeletedAsync))] // GET: galaxy-express/count
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> GetCountOfUsersNotDeletedAsync()
        {
            try
            {
                var count = await _userService.GetCountOfUsersNotDeletedAsync();
                _logger.LogInformation("{Count} entities are present in [{Table}]", count, _tableName);

                return Ok(count);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error in [{ErrorClassName}]->[{MethodName}] => {ErrorMessage}",
                    this.GetType().Name, nameof(GetCountOfUsersNotDeletedAsync), ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        #endregion
    }
}
