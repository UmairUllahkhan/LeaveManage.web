using LeaveManage.web.Constant;
using LeaveManage.web.Data;
using LeaveManage.web.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManage.web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveType;
        private readonly ApplicationDbContext _dbContext;
        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager, ILeaveTypeRepository leaveType) : base(context)
        {
            this._userManager = userManager;
            this._leaveType = leaveType;
            this._dbContext = context;

        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var emp = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leavetype = await _leaveType.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach (var employee in emp)
            {
                if (await LeaveExists(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    TypeId = leaveTypeId,
                    Period = period,
                    Number_of_Days = leavetype.Default_Day
                });
               

            }
            await AddRangeAsync(allocations);
            
        }

        public Task<bool> LeaveExists(string emp, int id, int period)
        {
            return _dbContext.LeaveAllocations.AnyAsync(q => //q.EmployeeId == emp
                                                          //&&
                                                          q.Id == id
                                                          && q.Equals(period));
        }

        //public Task<bool> LeaveExists(string emp, int id, int period)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
