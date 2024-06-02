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
        public GalaxyExpressDbContext _dbContext { get; set; }
        public IUserRepository Users { get; set; }
        public IEmailRepository Emails { get; set; }
        public IPhoneNumberRepository PhoneNumbers { get; set; }
        public IPaymentCardRepository PaymentCards { get; set; }
        public IParcelMachineRepository ParcelMachines { get; set; }
        public IPostBranchRepository PostBranches { get; set; }

        public UserManager<User> _userManager { get; set; }
        public RoleManager<IdentityRole<Guid>> _roleManager { get; set; }


        public UnitOfWork(
            GalaxyExpressDbContext dbContext, 

            IUserRepository users, 
            IEmailRepository emails,
            IPhoneNumberRepository phoneNumbers,
            IPaymentCardRepository paymentCards,

            UserManager<User> userManager, 
            RoleManager<IdentityRole<Guid>> roleManager, 
            IParcelMachineRepository parcelMachines, 
            IPostBranchRepository postBranches)
        {
            _dbContext = dbContext;

            Users = users;
            Emails = emails;
            PhoneNumbers = phoneNumbers;
            PaymentCards = paymentCards;
            ParcelMachines = parcelMachines;
            PostBranches = postBranches;

            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
