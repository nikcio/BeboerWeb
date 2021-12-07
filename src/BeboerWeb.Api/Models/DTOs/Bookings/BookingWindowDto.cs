using System;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class BookingWindowDto
    {
        public int Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int BookingItemId { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
