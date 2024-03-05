using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManage.web.Application_Configrations.Entities
{
    public class UserRoleSeedingConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "u8421m01-3dc0-0313-be9c-11c79d47mair",
                    UserId = "d8421d01-3dc0-4374-be9c-11c79d47efea"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "z8421u01-3dc0-0306-be9c-11c79d47bair",
                    UserId = "fa369996-9584-46c0-899b-a1992078c015"
                }


            );
        }
    }
}