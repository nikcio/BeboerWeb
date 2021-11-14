using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class EmployeeRepository : CrudRepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Employee>> logger) : base(dbContext, logger)
        {
        }
    }
}
