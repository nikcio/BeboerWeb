using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Calender
    {
        public int Id { get; set; }

        public virtual IEnumerable<BookingWindow> BookingWindows { get; set; }
        public virtual IEnumerable<IBookingItem> BookingItems { get; set; }
    }
}
