using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class BookingItemBookingsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IEnumerable<BookingDto> Bookings { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
