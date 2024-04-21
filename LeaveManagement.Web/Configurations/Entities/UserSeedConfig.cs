using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "fe0da13d-266b-43e1-916e-99a1c2ec6c17",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    NormalizedUserName="ADMIN@GMAIL.COM",
                    UserName="admin@gmail.com",
                    FirstName = "admin",
                    LastName = "admin",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed=true
                },new Employee
                {
                    Id = "9c18b0df-c7bb-4abd-a294-e387c54b0548",
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    NormalizedUserName="USER@GMAIL.COM",
                    UserName="user@gmail.com",
                    FirstName = "user",
                    LastName = "user",
                    PasswordHash = hasher.HashPassword(null, "User123!"),
                    EmailConfirmed=true
                }
          );
          
        }
    }
}