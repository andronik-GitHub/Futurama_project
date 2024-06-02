using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.DAL.Entities;
using Mapster;

namespace GalaxyExpress.API.Mapping.Configurations
{
    /// <summary>
    /// Registration PhoneNumber configurations
    /// </summary>
    public class PhoneNumberConfiguration
    {
        /// <summary>
        /// Registration PhoneNumber configuration
        /// </summary>
        public static void RegisterPhoneNumberConfig()
        {
            TypeAdapterConfig<PhoneNumber, GetDTO_PhoneNumber>
                .NewConfig()
                .Map(dest => dest.PhoneNumberId, src => src.PhoneNumberId)
                .Map(dest => dest.Number, src => src.Number)
                .Map(dest => dest.UserName, src => src.User.UserName)
                .Map(dest => dest.DateCreated, src => src.DateCreated)
                .Map(dest => dest.DateUpdated, src => src.DateUpdated)
                .Map(dest => dest.DateDeleted, src => src.DateDeleted)
                .TwoWays();

            TypeAdapterConfig<InsertDTO_PhoneNumber, PhoneNumber>
                .NewConfig()
                .Map(dest => dest.PhoneNumberId, _ => Guid.NewGuid())
                .Map(dest => dest.Number, src => src.Number)
                .Map(dest => dest.UserId, src => src.UserId)
                .TwoWays();

            TypeAdapterConfig<UpdateDTO_PhoneNumber, PhoneNumber>
                .NewConfig()
                .Map(dest => dest.PhoneNumberId, src => src.PhoneNumberId)
                .Map(dest => dest.Number, src => src.Number)
                .Map(dest => dest.UserId, src => src.UserId)
                .TwoWays();
        }
    }
}
