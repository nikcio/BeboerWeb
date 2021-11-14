using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class EmployeeService : CrudServiceBase<Employee, IEmployeeRepository>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repository, ILogger<ServiceBase<IEmployeeRepository>> logger) : base(repository, logger)
        {
        }
    }
}
