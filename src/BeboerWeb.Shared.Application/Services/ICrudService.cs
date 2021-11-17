using BeboerWeb.Shared.Application.Services.Models;

namespace BeboerWeb.Shared.Application.Services
{
    public interface ICrudService<T>
        where T : class
    {
        /// <summary>
        /// Gets all entities from the database
        /// </summary>
        /// <returns></returns>
        Task<IServiceResponse<List<T>>> GetAll();

        /// <summary>
        /// Gets an entity by an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IServiceResponse<T>> GetById(int id);

        /// <summary>
        /// Deletes an entity from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IServiceResponse<T>> DeleteById(int id);

        /// <summary>
        /// Updates a entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IServiceResponse<T>> Update(T entity);

        /// <summary>
        /// Adds an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IServiceResponse<T>> Add(T entity);
    }
}
