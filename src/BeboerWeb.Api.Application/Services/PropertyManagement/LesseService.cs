using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class LesseService : CrudServiceBase<Lesse, ILesseRepository>, ILesseService
    {
        public LesseService(ILesseRepository repository, ILogger<ServiceBase<ILesseRepository>> logger) : base(repository, logger)
        {
        }
    }
}
