using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface IBooking
    {
        BookingItem BookingItem { get; set; }
        DateTime EndTime { get; set; }
        int Id { get; set; }
        DateTime StartTime { get; set; }
        byte[] RowVersion { get; set; }
        IEnumerable<Document> Documents { get; set; }
        Tenant Tenant { get; set; }

        bool IsOverlapping(IBooking booking);
    }
}