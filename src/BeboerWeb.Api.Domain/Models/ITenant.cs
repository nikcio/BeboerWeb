using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface ITenant
    {
        int Id { get; set; }
        IEnumerable<ILessePeriod> LessePeriods { get; set; }
        IPerson Person { get; set; }
    }
}