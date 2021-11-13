using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class BookingWindow
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Calender Calender { get; set; }
        public virtual IEnumerable<Booking> Bookings { get; set; }
    }
}
