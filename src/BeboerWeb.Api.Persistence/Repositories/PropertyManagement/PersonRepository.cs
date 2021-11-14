using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class PersonRepository : CrudRepositoryBase<IPerson>, IPersonRepository
    {
        public PersonRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IPerson>> logger) : base(dbContext, logger)
        {
        }
    }
}
