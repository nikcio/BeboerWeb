﻿using BeboerWeb.Shared.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Shared.Application.Services.Models
{
    public class ServiceResponse<T> : IServiceResponse<T> where T : class
    {
        public ServiceResponse(StatusCode statusCode, T? reponse)
        {
            StatusCode = statusCode;
            Reponse = reponse;
        }

        public StatusCode StatusCode { get; set; }
        public T? Reponse { get; set; }
    }
}
