using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ILesse
    {
        string Apartment { get; set; }
        int Id { get; set; }
        IEnumerable<LessePeriod> LessePeriods { get; set; }
        IEnumerable<Property> Properties { get; set; }
        int Story { get; set; }
        byte[] RowVersion { get; set; }
    }
}