using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.DAL.Entities;
using Mapster;

namespace GalaxyExpress.API.Mapping.Configurations
{
    /// <summary>
    /// Registration Email configurations
    /// </summary>
    public class EmailConfiguration
    {
        /// <summary>
        /// Registration Email configuration
        /// </summary>
        public static void RegisterEmailConfig()
        {
            TypeAdapterConfig<Email, GetDTO_Email>
                .NewConfig()
                .Map(dest => dest.EmailId, src => src.EmailId)
                .Map(dest => dest.EmailAddress, src => src.EmailAddress)
                .Map(
                    dest => dest.UserName, 
                    src => $"{src.User.FirstName} {src.User.LastName}{(src.User.FatherName == null ? string.Empty : " " + src.User.FatherName)}")
                .Map(dest => dest.DateCreated, src => src.DateCreated)
                .Map(dest => dest.DateUpdated, src => src.DateUpdated)
                .Map(dest => dest.DateDeleted, src => src.DateDeleted)
                .TwoWays();

            TypeAdapterConfig<InsertDTO_Email, Email>
                .NewConfig()
                .Map(dest => dest.EmailId, _ => Guid.NewGuid())
                .Map(dest => dest.EmailAddress, src => src.EmailAddress)
                .Map(dest => dest.UserId, src => src.UserId)
                .TwoWays();

            TypeAdapterConfig<UpdateDTO_Email, Email>
                .NewConfig()
                .Map(dest => dest.EmailId, src => src.EmailId)
                .Map(dest => dest.EmailAddress, src => src.EmailAddress)
                .Map(dest => dest.UserId, src => src.UserId)
                .TwoWays();
        }
    }
}
