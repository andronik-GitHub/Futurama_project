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
using GalaxyExpress.BLL.Extensions;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using System.Security.Policy;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using GalaxyExpress.DAL.Entities.Identity.ResetPassword;

namespace GalaxyExpress.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        private readonly IEmailSender _emailSender;
        private readonly JWT _jwt;

        public UserService(IUnitOfWork uow, IOptions<JWT> jwt, IEmailSender emailSender)
        {
            _uow = uow;
            _jwt = jwt.Value;
            _emailSender = emailSender;
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
            var users = await _uow.Users.GetAllAsync();
            var usersWithRoles = new List<GetDTO_User>();

            foreach (var user in users)
            {
                var roles = await _uow._userManager.GetRolesAsync(user);
                var userDTO = MappingFunctions.MapSourceToDestination<User, GetDTO_User>(user);
                userDTO.Roles = roles;
                usersWithRoles.Add(userDTO);
            }

            return usersWithRoles;
        }

        public async Task<GetDTO_User?> GetAsync(Guid key)
        {
            User? user = await _uow.Users.GetByIdAsync(key);

            GetDTO_User? userDTO = MappingFunctions
                .MapSourceToDestination<User?, GetDTO_User?>(user); // Mapping with Mapster
            if (user != null && userDTO != null) userDTO.Roles = await _uow._userManager.GetRolesAsync(user);

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

        public async Task<User> AddEmailToUserAsync(Guid id, string email)
        {
            var user = await _uow.Users.GetByIdAsync(id);
            if (user == null) throw new Exception("User not found!");

            await _uow.Emails.CreateAsync(new Email { EmailAddress = email, UserId = user.Id });
            await _uow.SaveChangesAsync();


            // Detach existing user instance from the context if it's already being tracked
            var localUser = _uow._dbContext.Users.Local.FirstOrDefault(u => u.Id == user.Id);
            if (localUser != null) _uow._dbContext.Entry(localUser).State = EntityState.Detached;

            // Finally, we need to add these tokens into our RefreshTokens Table, so that we can reuse them
            _uow._dbContext.Users.Attach(user); // Attach the updated user entity
            user = await _uow.Users.GetByIdAsync(id);
            if (user == null) throw new Exception("User not found!");

            GetDTO_User? userDTO = MappingFunctions
                .MapSourceToDestination<User?, GetDTO_User?>(user); // Mapping with Mapster
            if (user != null && userDTO != null) userDTO.Roles = await _uow._userManager.GetRolesAsync(user);

            return user!;
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
            Console.WriteLine(userResult);
            if (roleResult.Succeeded) return userResult;

            throw new Exception("The user was successfully created, but the role could not be assigned to him!");
        }
        public async Task<Guid> RegisterManagerAsync(RegisterModel model)
        {
            var result = await RegisterAsync(model); // Register new user
            if (result == Guid.Empty) return result; // Checking whether the user has been created correctly

            // Mapping using Mapster
            var addRoleModel = MappingFunctions.MapSourceToDestination<RegisterModel, AddRoleModel>(model);
            addRoleModel.Role = Authorization.Roles.Manager.ToString();

            return (await AddRoleAsync(addRoleModel)) ? result : Guid.Empty; // Add to user new role and return result
        }
        public async Task<Guid> RegisterAdminAsync(RegisterModel model)
        {
            var result = await RegisterAsync(model); // Register new user
            if (result == Guid.Empty) return result; // Checking whether the user has been created correctly

            // Mapping using Mapster
            var addRoleModel = MappingFunctions.MapSourceToDestination<RegisterModel, AddRoleModel>(model);
            addRoleModel.Role = Authorization.Roles.Admin.ToString();

            return (await AddRoleAsync(addRoleModel)) ? result : Guid.Empty; // Add to user new role and return result
        }
        public async Task<bool> AddRoleAsync(AddRoleModel model)
        {
            try
            {
                var user = await _uow.Users.GetByLoginAsync(model.Login);

                if (user == null || (await _uow._userManager.CheckPasswordAsync(user, model.Password)) == false)
                    throw new Exception("Incorrect Credentials for user!");

                //  If the user is a valid one
                // Check if the passed Role is present in our system 
                var roleExists = Enum
                    .GetNames(typeof(Authorization.Roles))
                    .Any(x => x.ToLower() == model.Role?.ToLower());

                // If not, throws an error message
                if (roleExists == false) throw new Exception($"Role {model.Role} not found!");

                var validRole = Enum
                    .GetValues(typeof(Authorization.Roles))
                    .Cast<Authorization.Roles>()
                    .FirstOrDefault(x => x.ToString().ToLower() == model.Role?.ToLower());

                // Detach existing user instance from the context if it's already being tracked
                var localUser = _uow._dbContext.Users.Local.FirstOrDefault(u => u.Id == user.Id);
                if (localUser != null) _uow._dbContext.Entry(localUser).State = EntityState.Detached;

                // Finally, we need to add these tokens into our RefreshTokens Table, so that we can reuse them
                _uow._dbContext.Users.Attach(user); // Attach the updated user entity
                return (await _uow._userManager.AddToRoleAsync(user, validRole.ToString())).Succeeded;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\tErrors: {ex.Message}");
                return false;
            }
        }

        public async Task<AuthenticationModel> GetTokenAsync(LoginModel model)
        {
            // Creating a new Response Object,
            var authenticationModel = new AuthenticationModel();
            // Checking if the passed login is valid
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
                authenticationModel.Token = new JwtSecurityTokenHandler().WriteToken(token);
                authenticationModel.Emails = user.Emails.Select(e => e.EmailAddress).ToList();
                authenticationModel.PhoneNumbers = user.PhoneNumbers.Select(pn => pn.Number).ToList();
                authenticationModel.UserName = user.UserName;

                var roles = await _uow._userManager.GetRolesAsync(user).ConfigureAwait(false);
                authenticationModel.Roles = roles.ToList();

                // Check if there are any active refresh tokens available for the authenticated user
                if (user.RefreshTokens == null || user.RefreshTokens.Any(a => a.IsActive))
                {
                    // Set the available active refresh token to response
                    var activeRefreshToken = user.RefreshTokens?.FirstOrDefault(a => a.IsActive);
                    if (activeRefreshToken != null)
                    {
                        authenticationModel.RefreshToken = activeRefreshToken.Token;
                        authenticationModel.RefreshTokenExpiration = activeRefreshToken.Expires;
                    }
                }
                else
                {
                    // If there are not active Refresh Token available, we call our
                    // CreateRefreshToken method to generate a refresh token
                    var refreshToken = CreateRefreshToken();

                    //  Once generated, we set the details of the Refresh Token to the Response Object
                    authenticationModel.RefreshToken = refreshToken.Token;
                    authenticationModel.RefreshTokenExpiration = refreshToken.Expires;

                    // Detach existing user instance from the context if it's already being tracked
                    var localUser = _uow._dbContext.Users.Local.FirstOrDefault(u => u.Id == user.Id);
                    if (localUser != null) _uow._dbContext.Entry(localUser).State = EntityState.Detached;
                    _uow._dbContext.Users.Attach(user); // Attach the updated user entity

                    // Finally, we need to add these tokens into our RefreshTokens Table, so that we can reuse them
                    user.RefreshTokens.Add(refreshToken);
                    await _uow._userManager.UpdateAsync(user);
                    await _uow.SaveChangesAsync();
                }

                // Return the response object
                return authenticationModel;
            }

            // else returns a message saying incorrect credentials
            authenticationModel.IsAuthenticated = false;
            authenticationModel.Message = "Incorrect Credentials for user";
            return authenticationModel;
        }
        public async Task<AuthenticationModel> GetRefreshTokenAsync(string token)
        {
            // Create a new Response object
            var authenticationModel = new AuthenticationModel();

            // Check if there any matching user for the token in database
            var user = _uow._userManager.Users
                .SingleOrDefault(u => u.RefreshTokens == null || u.RefreshTokens.Any(t => t.Token == token));
            if (user == null) // If no matching user found, pass a message “Token did not match any users.”
            {
                authenticationModel.IsAuthenticated = false;
                authenticationModel.Message = "Token did not match any users.";

                return authenticationModel;
            }

            //  Get the Refresh token object of the matching record
            var refreshToken = user.RefreshTokens?.Single(x => x.Token == token);

            // Check is the selected token is active, if not active, send a message “Token Not Active.”
            if (refreshToken == null || !refreshToken.IsActive)
            {
                authenticationModel.IsAuthenticated = false;
                authenticationModel.Message = "Token Not Active.";

                return authenticationModel;
            }

            // Revoke Current Refresh Token. Every time we request a new JWT, we have to make sure
            // that we replace the refresh token with a new one
            refreshToken.Revoked = DateTime.UtcNow;

            // Generate new Refresh Token and save to Database
            RefreshToken newRefreshToken = CreateRefreshToken();
            user.RefreshTokens?.Add(newRefreshToken);
            await _uow._userManager.UpdateAsync(user);
            await _uow.SaveChangesAsync();

            // Generates new jwt
            authenticationModel.IsAuthenticated = true;

            JwtSecurityToken jwtSecurityToken = await CreateJwtToken(user);
            authenticationModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            authenticationModel.UserName = user.UserName;
            authenticationModel.Emails = user.Emails?.Select(e => e.EmailAddress).ToList() ?? new();
            authenticationModel.Roles = (await _uow._userManager.GetRolesAsync(user)).ToList();

            authenticationModel.RefreshToken = newRefreshToken.Token;
            authenticationModel.RefreshTokenExpiration = newRefreshToken.Expires;

            return authenticationModel;
        }
        public async Task<bool> RevokeTokenAsync(string token)
        {
            var user = _uow._userManager.Users
                .SingleOrDefault(u => u.RefreshTokens != null && u.RefreshTokens.Any(t => t.Token == token));

            // Return false if no user found with token
            if (user == null) return await Task.FromResult(false);

            var refreshToken = user.RefreshTokens?.Single(x => x.Token == token);

            // Return false if token is not active
            if (refreshToken == null || !refreshToken.IsActive) return await Task.FromResult(false);

            // If the passed refresh token is valid, we revoke it here and save to the database
            refreshToken.Revoked = DateTime.UtcNow;
            await _uow._userManager.UpdateAsync(user);
            await _uow.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task ForgotPasswordAsync(ForgotPasswordModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Email)) throw new Exception("Email is empty!");

            var user = await _uow.Users.GetByEmailAsync(model.Email) ?? throw new Exception("Email is not valid");

            var resetLink = $"https://link-to-reset-page.com";
            var message = new Message(
                new string[] { model.Email },
                "Forgot password",
                $@"
    <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
        <tr>
            <td align=""center"">
                <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""border: 1px solid #dddddd;"">
                    <tr>
                        <td align=""center"" bgcolor=""#0073e6"" style=""padding: 20px 0;"">
                            <h1 style=""color: #ffffff; margin: 0;"">Reset Your Password</h1>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#ffffff"" style=""padding: 20px;"">
                            <p>Hi {user.UserName},</p>
                            <p>You recently requested to reset your password for your account. Click the button below to reset it.</p>
                            <p><a href=""{resetLink}"" target=""_blank"" style=""display: inline-block; padding: 10px 20px; color: #ffffff; background-color: #0073e6; text-decoration: none;"">Reset Your Password</a></p>
                            <p>If you did not request a password reset, please ignore this email or reply to let us know. This password reset link is only valid for the next 24 hours.</p>
                            <p>Thanks,<br>The GalaxyExpress Team</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#f9f9f9"" style=""padding: 20px; text-align: center;"">
                            <p style=""margin: 0;"">If you're having trouble clicking the password reset button, copy and paste the URL below into your web browser:</p>
                            <p style=""margin: 0;""><a href=""{resetLink}"" target=""_blank"" style=""color: #0073e6;"">[Reset Link]</a></p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#0073e6"" style=""padding: 20px; text-align: center; color: #ffffff;"">
                            <p style=""margin: 0;"">&copy; {DateTime.Now.Year} GalaxyExpress. All rights reserved.</p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
");
            await _emailSender.SendEmailAsync(message);
        }

        public async Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Email)) throw new Exception("Email is empty!");

            var user = await _uow.Users.GetByEmailAsync(model.Email) ?? throw new Exception("Email is not valid");


            // Detach existing user instance from the context if it's already being tracked
            var localUser = _uow._dbContext.Users.Local.FirstOrDefault(u => u.Id == user.Id);
            if (localUser != null) _uow._dbContext.Entry(localUser).State = EntityState.Detached;

            // Finally, we need to add these tokens into our RefreshTokens Table, so that we can reuse them
            _uow._dbContext.Users.Attach(user); // Attach the updated user entity

            var code = await _uow._userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _uow._userManager.ResetPasswordAsync(user, code, model.Password);

            return result;
        }


        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            // Gets all the claims of the user(user details)
            var userClaims = await _uow._userManager.GetClaimsAsync(user);
            // Gets all the roles of the user
            var roles = await _uow._userManager.GetRolesAsync(user);

            // Creating a new JWT Security Token and returns them
            var roleClaims = roles != null ? roles.Select(role => new Claim("roles", role)).ToList() : new List<Claim>();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Emails?.Select(e => e.EmailAddress).FirstOrDefault() ?? ""),
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
        private static RefreshToken CreateRefreshToken()
        {
            byte[] randomNumber = new byte[64];
            using RandomNumberGenerator numberGenerator = RandomNumberGenerator.Create();

            numberGenerator.GetBytes(randomNumber);
            return new RefreshToken
            {
                Token = Convert.ToBase64String(randomNumber),
                Expires = DateTime.UtcNow.AddDays(10),
                Created = DateTime.UtcNow
            };
        }

        #endregion
    }
}
