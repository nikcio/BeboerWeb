using System;
using System.Linq;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class BookingWindow : IBookingWindow
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual BookingItem BookingItem { get; set; }
        public int BookingItemId { get; set; }
        public byte[] RowVersion { get; set; }

        public bool IsBookingInBookingWindow(IBooking booking)
        {
            return StartTime <= booking.StartTime && EndTime >= booking.EndTime;
        }

        public bool IsBookingOverlapping(IBooking booking)
        {
            return BookingItem.Bookings != null 
                && !BookingItem.Bookings.Where(item => IsBookingInBookingWindow(item)).Any(item => item.IsOverlapping(booking));
        }

        public bool IsBookingVaild(IBooking booking)
        {
            return IsBookingInBookingWindow(booking) && !IsBookingOverlapping(booking);
        }
    }
}
