using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface ICalender
    {
        IEnumerable<BookingItem> BookingItems { get; set; }
        IEnumerable<BookingWindow> BookingWindows { get; set; }
        int Id { get; set; }
        byte[] RowVersion { get; set; }
    }
}