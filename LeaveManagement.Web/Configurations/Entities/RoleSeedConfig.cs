using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "d65b2352-24f3-4120-ae1e-1fb56ddd90c8",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                }, new IdentityRole
                {
                    Id = "a58b2352-2da1-1120-be1e-1fb56ddd90c8",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
          ); 
        }
    }
}