using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Booking : IBooking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual IEnumerable<IBookingItem> BookingItems { get; set; }
        public virtual IBookingWindow BookingWindow { get; set; }

        public bool IsOverlapping(IBooking booking)
        {
            return (StartTime <= booking.StartTime && !(EndTime < booking.StartTime)) ||
                   (StartTime < booking.EndTime);
        }
    }
}
