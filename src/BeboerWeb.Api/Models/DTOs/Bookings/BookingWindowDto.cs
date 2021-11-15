using System;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class BookingWindowDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
