using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        GalaxyExpressContext_SQLServer _dbContext { get; set; }

        IUserRepository Users { get; }
        IEmailRepository Emails { get; }
        IPhoneNumberRepository PhoneNumbers { get; }
        IPaymentCardRepository PaymentCards { get; }

        UserManager<User> _userManager { get; set; }
        RoleManager<IdentityRole<Guid>> _roleManager { get; set; }

        Task SaveChangesAsync();
    }
}
