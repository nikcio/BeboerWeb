using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Shared.Application.Enums
{
    public enum StatusCode
    {
        Success = 200,
        Created = 201,
        NoContent = 204,
        NotFound = 404,
        Error = 500,
    }
}
