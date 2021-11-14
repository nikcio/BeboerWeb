using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class LesseRepositroy : CrudRepositoryBase<ILesse>, ILesseRepository
    {
        public LesseRepositroy(DbContext dbContext, ILogger<CrudRepositoryBase<ILesse>> logger) : base(dbContext, logger)
        {
        }
    }
}
