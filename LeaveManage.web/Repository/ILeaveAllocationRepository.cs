using LeaveManage.web.Data;

namespace LeaveManage.web.Repository
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int id);

        Task<bool> LeaveExists(string emp, int id, int period);



    }
}
