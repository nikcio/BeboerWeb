using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ILease
    {
        string Apartment { get; set; }
        int Id { get; set; }
        IEnumerable<LeasePeriod> LessePeriods { get; set; }
        Property Property { get; set; }
        Address Address { get; set; }
        int Story { get; set; }
        byte[] RowVersion { get; set; }
    }
}