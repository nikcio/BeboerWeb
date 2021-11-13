using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface ICalender
    {
        IEnumerable<IBookingItem> BookingItems { get; set; }
        IEnumerable<IBookingWindow> BookingWindows { get; set; }
        int Id { get; set; }
    }
}