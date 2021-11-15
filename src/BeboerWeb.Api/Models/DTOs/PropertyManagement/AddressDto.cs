using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
