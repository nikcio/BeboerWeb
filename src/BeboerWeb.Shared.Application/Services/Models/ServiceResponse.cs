using BeboerWeb.Shared.Application.Enums;

namespace BeboerWeb.Shared.Application.Services.Models
{
    public class ServiceResponse<T> : IServiceResponse<T> where T : class
    {
        public ServiceResponse(StatusCode statusCode, T? reponse)
        {
            StatusCode = statusCode;
            ReponseValue = reponse;
        }

        public StatusCode StatusCode { get; set; }
        public T? ReponseValue { get; set; }
    }
}
