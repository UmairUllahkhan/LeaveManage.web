
using System.ComponentModel.DataAnnotations;

namespace LeaveManage.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Leave_Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1,13, ErrorMessage = "Please enter the valid Days...")]
        public int Default_Day { get; set; }
    }
}
