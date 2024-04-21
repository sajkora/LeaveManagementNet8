using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "d65b2352-24f3-4120-ae1e-1fb56ddd90c8",
                    UserId= "fe0da13d-266b-43e1-916e-99a1c2ec6c17",
                },new IdentityUserRole<string>
                {
                    RoleId= "a58b2352-2da1-1120-be1e-1fb56ddd90c8",
                    UserId= "9c18b0df-c7bb-4abd-a294-e387c54b0548",
                }
           );
        }
    }
}