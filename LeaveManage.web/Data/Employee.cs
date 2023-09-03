using Microsoft.AspNetCore.Identity;

namespace LeaveManage.web.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? TaxId { get; set; }

        public DateTime DOB { get; set; }

        public DateTime JoiningDate { get; set; }


    }
}
