namespace BeboerWeb.Shared.Persistence.Repositories
{
    public interface ICrudRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task DeleteById(int id);
        void Update(T entity);
        Task Add(T entity);
    }
}
