using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface IBooking
    {
        IEnumerable<BookingItem> BookingItems { get; set; }
        BookingWindow BookingWindow { get; set; }
        DateTime EndTime { get; set; }
        int Id { get; set; }
        DateTime StartTime { get; set; }
        byte[] RowVersion { get; set; }

        bool IsOverlapping(IBooking booking);
    }
}