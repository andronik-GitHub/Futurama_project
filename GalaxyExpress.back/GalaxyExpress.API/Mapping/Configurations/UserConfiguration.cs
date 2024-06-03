using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Entities.Identity;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace GalaxyExpress.API.Mapping.Configurations
{
    /// <summary>
    /// Registration User configurations
    /// </summary>
    public static class UserConfiguration
    {
        /// <summary>
        /// Registration User configuration
        /// </summary>
        public static void RegisterUserConfig()
        {
            TypeAdapterConfig<User, GetDTO_User>
                .NewConfig()
                .Map(dest => dest.UserId, src => src.Id)
                .Map(dest => dest.UserName, src => src.UserName)
                .Map(dest => dest.Login, src => src.Login)
                .Map(dest => dest.Emails, src => src.Emails.Where(e => e.UserId == src.Id && e.DateDeleted == null).Select(e => e.EmailAddress))
                .Map(dest => dest.DateCreated, src => src.DateCreated)
                .Map(dest => dest.DateUpdated, src => src.DateUpdated)
                .Map(dest => dest.DateDeleted, src => src.DateDeleted)
                .TwoWays();

            TypeAdapterConfig<InsertDTO_User, User>
                .NewConfig()
                .Map(dest => dest.UserName, src => $"{src.FirstName}{src.LastName}{src.FatherName}")
                .Map(dest => dest.Login, src => src.Login)
                .Map(dest => dest.FirstName, src => src.FirstName)
                .Map(dest => dest.LastName, src => src.LastName)
                .Map(dest => dest.PasswordHash, src => new PasswordHasher<User>(null).HashPassword(null!, src.Password))
                .Map(dest => dest.FatherName, src => src.FatherName)
                .Map(dest => dest.Birthday, src => src.Birthday)
                .Map(dest => dest.Sex, src => src.Sex)
                .TwoWays();


            // Identity
            TypeAdapterConfig<RegisterModel, User>
                .NewConfig()
                .Map(dest => dest.Login, src => src.Login)
                .Map(dest => dest.PasswordHash, src => new PasswordHasher<User>(null).HashPassword(null!, src.Password))
                .Map(dest => dest.FirstName, src => src.FirstName)
                .Map(dest => dest.LastName, src => src.LastName)
                .Map(dest => dest.FatherName, src => src.FatherName)
                .TwoWays();
        }

        private static void RegisterAddRoleModel()
        {
            TypeAdapterConfig<RegisterModel, AddRoleModel>
                .NewConfig()
                .TwoWays()
                .Map(dest => dest.Login, src => src.Login)
                .Map(dest => dest.Password, src => src.Password);
        }
    }
}
