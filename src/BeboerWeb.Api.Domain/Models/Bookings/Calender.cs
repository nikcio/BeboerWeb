using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Calender : ICalender
    {
        public int Id { get; set; }

        public virtual IEnumerable<IBookingWindow> BookingWindows { get; set; }
        public virtual IEnumerable<IBookingItem> BookingItems { get; set; }
    }
}
