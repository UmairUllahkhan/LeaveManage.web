using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManage.web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        

        public int Number_of_Days { get; set; }

        [ForeignKey("TypeId")]
        public LeaveType Type { get; set; }
        public int TypeId { get; set; }

        public int EmployeeId { get; set; }

 


    }
}
