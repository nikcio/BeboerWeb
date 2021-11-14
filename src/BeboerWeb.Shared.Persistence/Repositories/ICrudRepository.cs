namespace BeboerWeb.Shared.Persistence.Repositories
{
    public interface ICrudRepository<T> : IRepository where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task DeleteByIdAsync(int id);
        void Update(T entity);
        Task AddAsync(T entity);
    }
}
