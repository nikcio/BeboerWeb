using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Documents
{
    public interface IDocument
    {
        int Id { get; set; }
        string Type { get; set; }
        IEnumerable<LeasePeriod> LeasePeriods { get; set; }
        IEnumerable<Booking> Bookings { get; set; }
        byte[] RowVersion { get; set; }
    }
}