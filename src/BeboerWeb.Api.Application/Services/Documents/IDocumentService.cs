using BeboerWeb.Api.Application.Persistence.Repositories.Documents;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Documents;

namespace BeboerWeb.Api.Application.Services.Documents
{
    public interface IDocumentService : ICrudServiceBase<Document, IDocumentRepository>
    {
    }
}