using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Tenant
    {
        public int Id { get; set; }

        public virtual Person Person { get; set; }

        public virtual IEnumerable<LessePeriod> LessePeriods { get; set; }
    }
}
