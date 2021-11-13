using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface IBookingWindow
    {
        IEnumerable<IBooking> Bookings { get; set; }
        ICalender Calender { get; set; }
        DateTime EndTime { get; set; }
        DateTime StartTime { get; set; }

        bool IsBookingInBookingWindow(IBooking booking);
        bool IsBookingOverlapping(IBooking booking);
        bool IsBookingVaild(IBooking booking);
    }
}