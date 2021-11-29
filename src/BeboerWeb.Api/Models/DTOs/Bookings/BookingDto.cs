using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class BookingDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<int> BookingItemIds { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
