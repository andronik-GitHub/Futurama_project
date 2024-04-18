using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public GalaxyExpressContext_SQLServer _dbContext { get; set; }
        public IUserRepository Users { get; set; }
        public IEmailRepository Emails { get; set; }
        public IPhoneNumberRepository PhoneNumbers { get; set; }
        public IPaymentCardRepository PaymentCards { get; set; }

        public UserManager<User> _userManager { get; set; }
        public RoleManager<IdentityRole<Guid>> _roleManager { get; set; }


        public UnitOfWork(
            GalaxyExpressContext_SQLServer dbContext, 

            IUserRepository users, 
            IEmailRepository emails,
            IPhoneNumberRepository phoneNumbers,
            IPaymentCardRepository paymentCards,

            UserManager<User> userManager, 
            RoleManager<IdentityRole<Guid>> roleManager)
        {
            _dbContext = dbContext;

            Users = users;
            Emails = emails;
            PhoneNumbers = phoneNumbers;
            PaymentCards = paymentCards;

            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
