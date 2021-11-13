using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface IBookingWindow
    {
        IEnumerable<Booking> Bookings { get; set; }
        Calender Calender { get; set; }
        DateTime EndTime { get; set; }
        DateTime StartTime { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }

        bool IsBookingInBookingWindow(IBooking booking);
        bool IsBookingOverlapping(IBooking booking);
        bool IsBookingVaild(IBooking booking);
    }
}