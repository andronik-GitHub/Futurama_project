using Mapster;
using System.Reflection;

namespace GalaxyExpress.API.Mapping.Configurations
{
    /// <summary>
    /// Registration Mapster configurations
    /// </summary>
    public static class MapsterConfiguration
    {
        /// <summary>
        /// Registration Mapster configuration
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors</param>
        public static void RegisterMapsterConfiguration(this IServiceCollection services)
        {
            UserConfiguration.RegisterUserConfig();
            EmailConfiguration.RegisterEmailConfig();
            PaymentCardConfiguration.RegisterPaymentCardConfig();
            PhoneNumberConfiguration.RegisterPhoneNumberConfig();

            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}
