using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual IEnumerable<IBookingItem> BookingItems { get; set; }
        public virtual BookingWindow BookingWindow { get; set; }
    }
}
