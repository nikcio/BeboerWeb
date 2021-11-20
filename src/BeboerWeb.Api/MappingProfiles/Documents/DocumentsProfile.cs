using AutoMapper;
using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Api.Models.DTOs.Documents;

namespace BeboerWeb.Api.MappingProfiles.Documents
{
    public class DocumentsProfile : Profile
    {
        public DocumentsProfile()
        {
            CreateMap<DocumentDto, Document>();
            CreateMap<Document, DocumentDto>();
        }
    }
}
