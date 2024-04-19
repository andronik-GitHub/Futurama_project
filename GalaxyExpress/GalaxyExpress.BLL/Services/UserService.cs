using GalaxyExpress.BLL.Mapping;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Services.Interfaces;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyExpress.DAL.Entities.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace GalaxyExpress.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        private readonly JWT _jwt;

        public UserService(IUnitOfWork uow, IOptions<JWT> jwt)
        {
            _uow = uow;
            _jwt = jwt.Value;
        }


        #region CRUD

        public async Task<Guid> CreateAsync(InsertDTO_User entity)
        {
            User user = MappingFunctions.MapSourceToDestination<InsertDTO_User, User>(entity); // Mapping with Mapster

            var id = await _uow.Users.CreateAsync(user);
            await _uow.SaveChangesAsync();

            return id;
        }
        public async Task<IEnumerable<GetDTO_User>> GetAllAsync()
        {
            // Use Mapster to project one collection onto another
            return MappingFunctions.MapListSourceToDestination<User, GetDTO_User>
                (await _uow.Users.GetAllAsync());
        }
        public async Task<GetDTO_User?> GetAsync(Guid key)
        {
            User? user = await _uow.Users.GetByIdAsync(key);

            GetDTO_User? userDTO = MappingFunctions
                .MapSourceToDestination<User?, GetDTO_User?>(user); // Mapping with Mapster

            return userDTO;
        }
        public async Task UpdateAsync(UpdateDTO_User entity)
        {
            var checkUser = await _uow.Users.GetByIdAsync(entity.UserId);
            if (checkUser == null) throw new Exception($"{nameof(User)} with id: [{entity.UserId}] was not found");

            _uow._dbContext.Entry(checkUser).State = EntityState.Detached;
            User user = (User)checkUser.Clone();

            foreach (var keyValuePair in entity.Values)
                if (keyValuePair.Key != "DateCreated" && keyValuePair.Key != "DateUpdated" && keyValuePair.Key != "DateDeleted")
                {
                    var property = user.GetType().GetProperty(keyValuePair.Key);

                    if (property != null && property.CanWrite)
                    {
                        if (property.Name == "PasswordHash")
                            property.SetValue(user, new PasswordHasher<User>().HashPassword(null!, keyValuePair.Value));
                        else
                            property.SetValue(user, keyValuePair.Value);

                        if (property.Name is "PasswordHash" or "UserName")
                            user.GetType().GetProperty("SecurityStamp")?.SetValue(user, Guid.NewGuid().ToString("N").ToUpper());
                    }
                }

            _uow._dbContext.Entry(user).State = EntityState.Modified;

            await _uow.Users.UpdateAsync(user);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid key)
        {
            await _uow.Users.DeleteAsync(key);
            await _uow.SaveChangesAsync();
        }

        #endregion

        #region Extensions

        public async Task<int> GetCountOfUsersAsync()
        {
            var count = await _uow.Users.GetCountOfUsersAsync();

            return count;
        }
        public async Task<int> GetCountOfUsersNotDeletedAsync()
        {
            var count = await _uow.Users.GetCountOfUsersNotDeletedAsync();

            return count;
        }

        #endregion

        #region Identity

        public async Task<Guid> RegisterAsync(RegisterModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Password)) throw new Exception("Password is empty!");

            var user = MappingFunctions.MapSourceToDestination<RegisterModel, User>(model); // Mapping using Mapster

            // Checking if the login is already registered
            if ((await _uow.Users.GetAllAsync()).FirstOrDefault(u => u.Login == model.Login) != null)
                throw new Exception("Login is already registered!");
            // Checking if the phone number is already registered
            if ((await _uow.PhoneNumbers.GetAllAsync()).Where(pn => pn.Number == model.PhoneNumber).FirstOrDefault() != null)
                throw new Exception("Phone number is already registered!");

            // If no username has been set, then the default username is set
            if (string.IsNullOrEmpty(user.UserName)) user.UserName = Authorization.default_username + Guid.NewGuid().ToString();

            var userResult = await _uow.Users.CreateAsync(user);
            if (userResult == Guid.Empty) return Guid.Empty;

            var phoneNumberResult = await _uow.PhoneNumbers.CreateAsync(new PhoneNumber
            {
                PhoneNumberId = Guid.NewGuid(),
                Number = model.PhoneNumber,
                UserId = userResult
            });
            if (userResult == Guid.Empty) 
                throw new Exception("The user was successfully created, but it was not possible to link the phone number to him!");

            var roleResult = await _uow._userManager.AddToRoleAsync(user, Authorization.default_role.ToString());
            if (roleResult.Succeeded) return userResult;

            throw new Exception("The user was successfully created, but the role could not be assigned to him!");
        }
        public async Task<AuthenticationModel> GetTokenAsync(LoginModel model)
        {
            // Creating a new Response Object,
            var authenticationModel = new AuthenticationModel();
            // Checking if the passeed login is valid
            var user = await _uow.Users.GetByLoginAsync(model.Login);

            // Return a message if not valid
            if (user == null)
            {
                authenticationModel.IsAuthenticated = false;
                authenticationModel.Message = "No Accounts Registered with this login";
                return authenticationModel;
            }

            // Checking if the password is valid
            if (await _uow._userManager.CheckPasswordAsync(user, model.Password ?? string.Empty))
            {
                authenticationModel.IsAuthenticated = true;

                // Call the CreateJWTToken function
                JwtSecurityToken token = await CreateJwtToken(user);
                Console.WriteLine(token);
                authenticationModel.Token = new JwtSecurityTokenHandler().WriteToken(token);
                authenticationModel.Emails = user.Emails.Select(e => e.EmailAddress).ToList();
                authenticationModel.PhoneNumbers = user.PhoneNumbers.Select(pn => pn.Number).ToList();
                authenticationModel.UserName = user.UserName;

                var roles = await _uow._userManager.GetRolesAsync(user).ConfigureAwait(false);
                authenticationModel.Roles = roles.ToList();


                // Check if there are any active refresh tokens available for the authenticated user
                //if (user.RefreshTokens == null || user.RefreshTokens.Any(a => a.IsActive))
                //{
                //    // Set the available active refresh token to response
                //    var activeRefreshToken = user.RefreshTokens?.FirstOrDefault(a => a.IsActive);
                //    if (activeRefreshToken != null)
                //    {
                //        authenticationModel.RefreshToken = activeRefreshToken.Token;
                //        authenticationModel.RefreshTokenExpiration = activeRefreshToken.Expires;
                //    }
                //}
                //else
                //{
                //    // If there are not active Refresh Token available, we call our
                //    // CreateRefreshToken method to generate a refresh token
                //    var refreshToken = CreateRefreshToken();

                //    //  Once generated, we set the details of the Refresh Token to the Response Object
                //    authenticationModel.RefreshToken = refreshToken.Token;
                //    authenticationModel.RefreshTokenExpiration = refreshToken.Expires;
                //    user.RefreshTokens.Add(refreshToken);

                //    // Finally, we need to add these tokens into our RefreshTokens Table, so that we can reuse them
                //    await _uow._userManager.UpdateAsync(user);
                //    await _uow.SaveChangesAsync();
                //}


                // Return the response object
                return authenticationModel;
            }

            // else returns a message saying incorrect credentials
            authenticationModel.IsAuthenticated = false;
            authenticationModel.Message = "Incorrect Credentials for user";
            return authenticationModel;
        }
        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            // Gets all the claims of the user(user details)
            var userClaims = await _uow._userManager.GetClaimsAsync(user);
            // Gets all the roles of the user
            var roles = await _uow._userManager.GetRolesAsync(user);

            // Creating a new JWT Security Token and returns them
            var roleClaims = new List<Claim>();
            roles.ToList().ForEach(role => roleClaims.Add(new Claim("roles", role)));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Emails.Select(e => e.EmailAddress).FirstOrDefault() ?? ""),
                new Claim("uid", user.Id.ToString()),
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }

        #endregion
    }
}
