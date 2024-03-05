using LeaveManage.web.Data;
using LeaveManage.web.Repository;

namespace LeaveManage.web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
