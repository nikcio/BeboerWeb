using BeboerWeb.Api.Application.Persistence.Repositories.Documents;
using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Documents
{
    public class DocumentRepository : CrudRepositoryBase<Document>, IDocumentRepository
    {
        public DocumentRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Document>> logger) : base(dbContext, logger)
        {
        }
    }
}
