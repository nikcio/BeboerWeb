using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class LeasePeriod : ILeasePeriod
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<Tenant> Tenants { get; set; }
        public Lease Lesse { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
