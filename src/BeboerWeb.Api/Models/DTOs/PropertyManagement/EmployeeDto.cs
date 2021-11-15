using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
