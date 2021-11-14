using BeboerWeb.Api.Domain.Models.Bookings;
using System.Collections.Generic;
using System;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class BookingDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
