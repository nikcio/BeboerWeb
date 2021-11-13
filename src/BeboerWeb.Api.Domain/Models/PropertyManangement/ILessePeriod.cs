using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ILessePeriod
    {
        DateTime EndDate { get; set; }
        int Id { get; set; }
        Lesse Lesse { get; set; }
        DateTime StartDate { get; set; }
        IEnumerable<Tenant> Tenants { get; set; }
        byte[] RowVersion { get; set; }
    }
}