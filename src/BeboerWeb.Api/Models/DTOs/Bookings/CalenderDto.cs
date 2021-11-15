using BeboerWeb.Api.Domain.Models.Bookings;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class CalenderDto
    {
        public int Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
