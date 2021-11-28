using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class Booking : IBooking
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual BookingItem BookingItem { get; set; }
        public virtual IEnumerable<Document> Documents { get; set; }
        public virtual Tenant Tenant { get; set; }

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
