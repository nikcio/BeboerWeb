using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class PersonService : CrudServiceBase<Person, IPersonRepository>, IPersonService
    {
        public PersonService(IPersonRepository repository, ILogger<ServiceBase<IPersonRepository>> logger) : base(repository, logger)
        {
        }
    }
}
