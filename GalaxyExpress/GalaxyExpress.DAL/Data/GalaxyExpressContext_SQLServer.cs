using GalaxyExpress.DAL.Bogus;
using GalaxyExpress.DAL.Data.Configurations;
using GalaxyExpress.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Data
{
    public class GalaxyExpressContext_SQLServer : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        // public DbSet<User> Users { get; set; } = default!;
        public DbSet<Email> Emails { get; set; } = default!;
        public DbSet<PhoneNumber> PhoneNumbers { get; set; } = default!;
        public DbSet<PaymentCard> PaymentCards { get; set; } = default!;

        public GalaxyExpressContext_SQLServer
            (DbContextOptions<GalaxyExpressContext_SQLServer> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PhoneNumberConfiguration());
            builder.ApplyConfiguration(new EmailConfiguration());
            builder.ApplyConfiguration(new PaymentCardConfiguration());


            // Seeding data
            //builder.Entity<IdentityRole<Guid>>().HasData(DataGenerator.Roles);
            //builder.Entity<User>().HasData(DataGenerator.Users);
            //builder.Entity<IdentityUserRole<Guid>>().HasData(DataGenerator.UsersRoles);

            //builder.Entity<PhoneNumber>().HasData(DataGenerator.PhoneNumbers);
            //builder.Entity<Email>().HasData(DataGenerator.Emails);
            //builder.Entity<PaymentCard>().HasData(DataGenerator.PaymentCards);
        }
    }
}
