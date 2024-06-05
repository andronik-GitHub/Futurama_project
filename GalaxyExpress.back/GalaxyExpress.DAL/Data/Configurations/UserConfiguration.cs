using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("AspNetUsers");

            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.DateCreated)
                .HasDefaultValueSql("GETUTCDATE()");


            builder
                .Property(u => u.Login)
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();
            builder
                .HasIndex(u => u.Login)
                .IsUnique();
            builder
                .Property(u => u.FirstName)
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();
            builder
                .Property(u => u.LastName)
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();
            builder
                .Property(u => u.FatherName)
                .HasColumnType("NVARCHAR(50)");
            builder
                .Property(u => u.Birthday)
                .HasColumnType("DATETIME2");
            builder
                .Property(u => u.BonusAccount)
                .HasColumnType("DECIMAL(18,2)")
                .HasDefaultValue(0);
            builder
                .OwnsMany(
                    user => user.RefreshTokens,
                    refreshToken =>
                    {
                        refreshToken.Property(rt => rt.Token).IsRequired();
                        refreshToken.Property(rt => rt.Expires).IsRequired();
                        refreshToken.Property(rt => rt.Created).IsRequired();
                        refreshToken.Property(rt => rt.Revoked).IsRequired();
                    });


            builder // one to many - Users to PhoneNumbers
                .HasMany(u => u.PhoneNumbers)
                .WithOne(pn => pn.User)
                .HasForeignKey(pn => pn.UserId);
            builder // one to many - Users to Emails
                .HasMany(u => u.Emails)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);
            builder // one to many - Users to PaymentCards
                .HasMany(u => u.PaymentCards)
                .WithOne(pc => pc.User)
                .HasForeignKey(pc => pc.UserId);
        }
    }
}
