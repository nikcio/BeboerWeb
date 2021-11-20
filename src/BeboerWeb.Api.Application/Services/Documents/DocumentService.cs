using BeboerWeb.Api.Application.Persistence.Repositories.Documents;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Documents;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Documents
{
    public class DocumentService : CrudServiceBase<Document, IDocumentRepository>, IDocumentService
    {
        public DocumentService(IDocumentRepository repository, ILogger<ServiceBase<IDocumentRepository>> logger) : base(repository, logger)
        {
        }
    }
}
