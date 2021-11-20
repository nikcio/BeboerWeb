using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Documents
{
    public class Document : IDocument
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual IEnumerable<LeasePeriod> LeasePeriods { get; set; }
        public virtual IEnumerable<Booking> Bookings { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
