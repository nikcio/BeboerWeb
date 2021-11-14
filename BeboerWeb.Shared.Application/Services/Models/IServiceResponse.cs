using BeboerWeb.Shared.Application.Enums;

namespace BeboerWeb.Shared.Application.Services.Models
{
    public interface IServiceResponse<T> where T : class
    {
        T? Reponse { get; set; }
        StatusCode StatusCode { get; set; }
    }
}