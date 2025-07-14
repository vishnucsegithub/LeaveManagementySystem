using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagement.web.Constants;

namespace LeaveManagement.web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "4f42fada-4765-459e-8455-1153b3691db3", //The value under double qouates is called guid
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "2f9678d8-23ac-4161-b07e-d3d25167dd9c", //The value under double qouates is called guid
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }

            );
        }
    }
}