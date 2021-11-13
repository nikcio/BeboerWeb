using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Booking : IBooking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual IEnumerable<BookingItem> BookingItems { get; set; }
        public virtual BookingWindow BookingWindow { get; set; }

        public byte[] RowVersion { get; set; }

        public bool IsOverlapping(IBooking booking)
        {
            return ((StartTime != booking.StartTime) || (EndTime != booking.EndTime)) &&
                (
                   StartTime < booking.StartTime && EndTime < booking.EndTime && EndTime < booking.StartTime ||
                   StartTime > booking.StartTime && EndTime > booking.EndTime && StartTime > booking.EndTime
                );
        }
    }
}
