using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class CompanyRepository : CrudRepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Company>> logger) : base(dbContext, logger)
        {
        }
    }
}
