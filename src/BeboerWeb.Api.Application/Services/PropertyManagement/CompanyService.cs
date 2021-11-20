using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class CompanyService : CrudServiceBase<Company, ICompanyRepository>, ICompanyService
    {
        public CompanyService(ICompanyRepository repository, ILogger<ServiceBase<ICompanyRepository>> logger) : base(repository, logger)
        {
        }
    }
}
