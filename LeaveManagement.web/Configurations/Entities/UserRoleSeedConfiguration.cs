using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
              new IdentityUserRole<string>
              {
                  RoleId = "4f42fada-4765-459e-8455-1153b3691db3",
                  UserId = "4ef245a8-7aee-43e5-aae7-b3ecf1b6efa4"
              },
              new IdentityUserRole<string>
              {
                  RoleId = "2f9678d8-23ac-4161-b07e-d3d25167dd9c",
                  UserId = "650c2894-3d0c-40ff-9a31-9aa0cae71932"
              }
            );
        }
    }
}