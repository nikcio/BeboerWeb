using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Shared.Application.Services
{
    public interface ICrudService<T> 
        where T : class
    {
        Task<IServiceResponse<List<T>>> GetAll();
        Task<IServiceResponse<T>> GetById(int id);
        Task<IServiceResponse<T>> DeleteById(int id);
        Task<IServiceResponse<T>> Update(T entity);
        Task<IServiceResponse<T>> Add(T entity);
    }
}
