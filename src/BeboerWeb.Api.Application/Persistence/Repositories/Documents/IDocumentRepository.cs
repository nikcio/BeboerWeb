using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Shared.Persistence.Repositories;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Documents
{
    public interface IDocumentRepository : IRepository, ICrudRepository<Document>
    {
    }
}
