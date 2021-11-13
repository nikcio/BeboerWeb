using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class BookingWindow : IBookingWindow
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual ICalender Calender { get; set; }
        public virtual IEnumerable<IBooking> Bookings { get; set; }

        public bool IsBookingInBookingWindow(IBooking booking)
        {
            return StartTime < booking.StartTime && EndTime > booking.EndTime;
        }

        public bool IsBookingOverlapping(IBooking booking)
        {
            return !Bookings.Any(item => item.IsOverlapping(booking));
        }

        public bool IsBookingVaild(IBooking booking)
        {
            return IsBookingInBookingWindow(booking) && IsBookingOverlapping(booking);
        }
    }
}
