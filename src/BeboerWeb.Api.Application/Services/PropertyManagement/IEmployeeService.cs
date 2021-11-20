using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public interface IEmployeeService : ICrudServiceBase<Employee, IEmployeeRepository>
    {
    }
}