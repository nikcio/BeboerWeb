using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Calender : ICalender
    {
        public int Id { get; set; }

        public virtual IEnumerable<BookingWindow> BookingWindows { get; set; }
        public virtual IEnumerable<BookingItem> BookingItems { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
