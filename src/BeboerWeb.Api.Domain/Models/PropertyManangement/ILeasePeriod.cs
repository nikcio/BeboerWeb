using BeboerWeb.Api.Domain.Models.Documents;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ILeasePeriod
    {
        DateTime? EndDate { get; set; }
        int Id { get; set; }
        Lease Lesse { get; set; }
        DateTime StartDate { get; set; }
        IEnumerable<Tenant> Tenants { get; set; }
        byte[] RowVersion { get; set; }
        IEnumerable<Document> Documents { get; set; }
    }
}