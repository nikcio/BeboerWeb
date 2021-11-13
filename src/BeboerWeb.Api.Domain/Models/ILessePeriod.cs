using System;

namespace BeboerWeb.Api.Domain.Models
{
    public interface ILessePeriod
    {
        DateTime EndDate { get; set; }
        int Id { get; set; }
        ILesse Lesse { get; set; }
        DateTime StartDate { get; set; }
        System.Collections.Generic.IEnumerable<ITenant> Tenants { get; set; }
    }
}