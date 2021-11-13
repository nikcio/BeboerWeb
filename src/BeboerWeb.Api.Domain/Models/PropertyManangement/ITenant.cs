using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ITenant
    {
        int Id { get; set; }
        IEnumerable<LessePeriod> LessePeriods { get; set; }
        Person Person { get; set; }
        byte[] RowVersion { get; set; }
    }
}