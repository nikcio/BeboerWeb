using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
