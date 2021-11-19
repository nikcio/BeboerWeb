using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ITenant
    {
        int Id { get; set; }
        IEnumerable<LeasePeriod> LessePeriods { get; set; }
        Person Person { get; set; }
        byte[] RowVersion { get; set; }
    }
}