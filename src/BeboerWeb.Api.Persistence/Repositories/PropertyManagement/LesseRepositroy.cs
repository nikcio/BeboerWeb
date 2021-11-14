using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class LesseRepositroy : CrudRepositoryBase<Lesse>, ILesseRepository
    {
        public LesseRepositroy(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Lesse>> logger) : base(dbContext, logger)
        {
        }
    }
}
