using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Tenant : ITenant
    {
        public int Id { get; set; }

        public virtual Person Person { get; set; }

        public virtual IEnumerable<LeasePeriod> LessePeriods { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
