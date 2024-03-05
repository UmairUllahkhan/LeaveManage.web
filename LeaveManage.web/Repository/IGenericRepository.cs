namespace LeaveManage.web.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();

        Task DeleteAsync(int id);

        Task UpdateAsync(T entity);

        Task<T> AddAsync(T entity);    


    }
}
