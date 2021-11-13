using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface IBooking
    {
        IEnumerable<IBookingItem> BookingItems { get; set; }
        IBookingWindow BookingWindow { get; set; }
        DateTime EndTime { get; set; }
        int Id { get; set; }
        DateTime StartTime { get; set; }

        bool IsOverlapping(IBooking booking);
    }
}