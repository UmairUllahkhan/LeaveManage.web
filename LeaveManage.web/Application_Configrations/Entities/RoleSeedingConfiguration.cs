using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManage.web.Application_Configrations.Entities
{
    internal class RoleSeedingConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(

                new IdentityRole 
                {
                    Id             = "u8421m01-3dc0-0313-be9c-11c79d47mair",
                    Name           = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },

                new IdentityRole
                {
                    Id = "z8421u01-3dc0-0306-be9c-11c79d47bair",
                    Name = "User",
                    NormalizedName = "USER"
                }



            );
        }
    }
}