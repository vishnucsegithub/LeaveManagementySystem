using LeaveManagement.web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
   public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
               new Employee
               {
                   Id = "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4", //The value under double qouates is called guid
                   Email = "admin1@gmail.com",
                   NormalizedEmail = "ADMIN1@GMAIL.COM",
                   UserName = "admin1@gmail.com",
                   NormalizedUserName = "ADMIN1@GMAIL.COM",
                   FirstName ="admin",
                   LastName = "LMS",
                   PasswordHash = hasher.HashPassword(null, "@Admin1"),
                   EmailConfirmed = true
               },
                new Employee
                {
                    Id = "650c2894-3d0c-40ff-9a31-9aa0cae71932", //The value under double qouates is called guid
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    UserName = "user@gmail.com",
                    NormalizedUserName = "USER@GMAIL.COM",
                    FirstName = "user",
                    LastName = "LMS",
                    PasswordHash = hasher.HashPassword(null, "@User1"),
                    EmailConfirmed = true
                }

           );
        }
    }
}