using GalaxyExpress.BLL.DTOs.PaymentCardDTOs;
using GalaxyExpress.DAL.Entities;
using Mapster;

namespace GalaxyExpress.API.Mapping.Configurations
{
    /// <summary>
    /// Registration PaymentCard configurations
    /// </summary>
    public class PaymentCardConfiguration
    {
        /// <summary>
        /// Registration PaymentCard configuration
        /// </summary>
        public static void RegisterPaymentCardConfig()
        {
            TypeAdapterConfig<PaymentCard, GetDTO_PaymentCard>
                .NewConfig()
                .Map(dest => dest.CardId, src => src.CardId)
                .Map(dest => dest.CardNumber, src => src.CardNumber)
                .Map(dest => dest.Validity, src => src.Validity)
                .Map(dest => dest.CVV, src => src.CVV)
                .Map(
                    dest => dest.UserName,
                    src => $"{src.User.FirstName} {src.User.LastName}{(src.User.FatherName == null ? string.Empty : " " + src.User.FatherName)}")
                .Map(dest => dest.DateCreated, src => src.DateCreated)
                .Map(dest => dest.DateUpdated, src => src.DateUpdated)
                .Map(dest => dest.DateDeleted, src => src.DateDeleted)
                .TwoWays();

            TypeAdapterConfig<InsertDTO_PaymentCard, PaymentCard>
                .NewConfig()
                .Map(dest => dest.CardId, _ => Guid.NewGuid())
                .Map(dest => dest.CardNumber, src => src.CardNumber)
                .Map(dest => dest.Validity, src => src.Validity)
                .Map(dest => dest.CVV, src => src.CVV)
                .Map(dest => dest.UserId, src => src.UserId)
                .TwoWays();

            TypeAdapterConfig<UpdateDTO_PaymentCard, PaymentCard>
                .NewConfig()
                .Map(dest => dest.CardId, src => src.CardId)
                .Map(dest => dest.CardNumber, src => src.CardNumber)
                .Map(dest => dest.Validity, src => src.Validity)
                .Map(dest => dest.CVV, src => src.CVV)
                .Map(dest => dest.UserId, src => src.UserId)
                .TwoWays();
        }
    }
}
