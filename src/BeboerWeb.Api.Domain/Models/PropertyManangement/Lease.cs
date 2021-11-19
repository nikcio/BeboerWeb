using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Lease : ILease
    {
        public int Id { get; set; }
        public int Story { get; set; }
        public string Apartment { get; set; }

        public virtual IEnumerable<LeasePeriod> LessePeriods { get; set; }
        public virtual IEnumerable<Property> Properties { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
