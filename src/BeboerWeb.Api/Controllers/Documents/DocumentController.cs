using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Documents;
using BeboerWeb.Api.Application.Services.Documents;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Api.Models.DTOs.Documents;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.Documents
{
    [Route("api/propertymanagement/document")]
    [ApiController]
    public class DocumentController : CrudControllerBase<DocumentDto, Document, IDocumentRepository, IDocumentService>
    {
        public DocumentController(IDocumentService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
