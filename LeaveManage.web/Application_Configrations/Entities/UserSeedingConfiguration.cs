using LeaveManage.web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManage.web.Application_Configrations.Entities
{
    public class UserSeedingConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var passhash = new PasswordHasher<Employee>();
            builder.HasData(

                new Employee
                {
                    Id = "d8421d01-3dc0-4374-be9c-11c79d47efea",
                    Email = "khoula007@hotmail.com",
                    NormalizedEmail = "KHOULA007@HOTMAIL.COM",
                    NormalizedUserName = "KHOULA007@HOTMAIL.COM",
                    UserName = "khoula007@hotmail.com",
                    PasswordHash = passhash.HashPassword(null, "Germany@2023")
                    
                },

                new Employee
                {
                    Id = "fa369996-9584-46c0-899b-a1992078c015",
                    Email = "khoula009@hotmail.com",
                    NormalizedEmail = "KHOULA009@HOTMAIL.COM",
                    NormalizedUserName = "KHOULA009@HOTMAIL.COM",
                    UserName = "khoula009@hotmail.com",
                    PasswordHash = passhash.HashPassword(null, "Germany@2023")
                }



            );
        }
    }
}