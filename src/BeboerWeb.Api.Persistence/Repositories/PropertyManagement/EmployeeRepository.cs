using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class EmployeeRepository : CrudRepositoryBase<IEmployee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IEmployee>> logger) : base(dbContext, logger)
        {
        }
    }
}
