using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Tenant : ITenant
    {
        public int Id { get; set; }

        public virtual IPerson Person { get; set; }

        public virtual IEnumerable<ILessePeriod> LessePeriods { get; set; }
    }
}
