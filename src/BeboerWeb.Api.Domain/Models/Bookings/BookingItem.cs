using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class BookingItem : IBookingItem
    {
        public int Id { get; set; }
        public virtual IEnumerable<BookingWindow> BookingWindows { get; set; }
        public virtual IEnumerable<Booking> Bookings { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
