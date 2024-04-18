using Bogus;
using GalaxyExpress.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Bogus
{
    public class DataGenerator
    {
        public static List<Email> Emails = new();
        public static List<PhoneNumber> PhoneNumbers = new();
        public static List<PaymentCard> PaymentCards = new();

        public static List<User> Users = new();
        public static List<IdentityRole<Guid>> Roles = new();
        public static List<IdentityUserRole<Guid>> UsersRoles = new();

        private const int USERS = 140;
        private const int EMAILS = USERS * 2;
        private const int PHONENUMBERS = USERS * 2;
        private const int PAYMENTCARDS = USERS * 2;


        private static Faker<User> GetUserGenerator()
        {
            return new Faker<User>()
                .RuleFor(u => u.Id, _ => Guid.NewGuid())
                .RuleFor(u => u.Login, f => f.Person.UserName)
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.FatherName, f => f.Random.Int(0, 100) > 50 ? f.Person.FirstName : null)
                .RuleFor(u => u.Birthday, f => 
                    f.Random.Int(0, 100) > 50 ? f.Date.Between(DateTime.Now.AddYears(-100), DateTime.Now.AddYears(-15)) : null)
                .RuleFor(u => u.Sex, f => f.PickRandom<Gender>())
                .RuleFor(u => u.BonusAccount, f => f.Random.Decimal(0.0m, 1000.0m))
                .RuleFor(u => u.PasswordHash, f => new PasswordHasher<User>().HashPassword(null!, f.Internet.Password()));
        }
        private static Faker<PhoneNumber> GetPhoneNumberGenerator(Guid UserId)
        {
            return new Faker<PhoneNumber>()
                .RuleFor(pn => pn.PhoneNumberId, _ => Guid.NewGuid())
                .RuleFor(pn => pn.Number, f => $"+{f.Random.Int(1, 999)} {f.Phone.PhoneNumber(@"## (###) ##-##")}")
                .RuleFor(pn => pn.UserId, _ => UserId);
        }
        private static Faker<PaymentCard> GetPaymentCardGenerator(Guid UserId)
        {
            return new Faker<PaymentCard>()
                .RuleFor(pc => pc.CardId, _ => Guid.NewGuid())
                .RuleFor(pc => pc.CardNumber, f => $"{f.Random.Int(1, 9)}{f.Phone.PhoneNumber(@"###############")}")
                .RuleFor(pc => pc.Validity, f => $"{f.Random.Int(1, 12):D2}/{f.Random.Int(1, 28):D2}")
                .RuleFor(pc => pc.CVV, f => f.Phone.PhoneNumber(@"###"))
                .RuleFor(pc => pc.UserId, _ => UserId);
        }
        private static Faker<Email> GetEmailGenerator(Guid UserId)
        {
            return new Faker<Email>()
                .RuleFor(e => e.EmailId, _ => Guid.NewGuid())
                .RuleFor(e => e.EmailAddress, f => f.Internet.Email())
                .RuleFor(e => e.UserId, _ => UserId);
        }

        public static void InitBogusData()
        {
            // Add IdentityRoles
            //Roles.AddRange(new List<IdentityRole<Guid>>
            //{
            //    new IdentityRole<Guid>
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = Authorization.Roles.Administrator.ToString(),
            //        NormalizedName = Authorization.Roles.Administrator.ToString().ToUpper()
            //    },
            //    new IdentityRole<Guid>
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = Authorization.Roles.Moderator.ToString(),
            //        NormalizedName = Authorization.Roles.Moderator.ToString().ToUpper()
            //    },
            //    new IdentityRole<Guid>
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = Authorization.Roles.User.ToString(),
            //        NormalizedName = Authorization.Roles.User.ToString().ToUpper()
            //    }
            //});

            // Add IdentityUsers
            Users.AddRange(GetUserGenerator().Generate(USERS));

            // Add IdentityUserRole
            //UsersRoles.AddRange(Users.Select(u => new IdentityUserRole<Guid>
            //{
            //    RoleId = Roles[new Random().Next(0, Roles.Count)].Id,
            //    UserId = u.Id
            //}));


            Users.ForEach(user => Emails.AddRange(GetEmailGenerator(user.Id).Generate(2)));
            Users.ForEach(user => PhoneNumbers.AddRange(GetPhoneNumberGenerator(user.Id).Generate(2)));
            Users.ForEach(user => PaymentCards.AddRange(GetPaymentCardGenerator(user.Id).Generate(2)));
        }
    }
}
