using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Lesse : ILesse
    {
        public int Id { get; set; }
        public int Story { get; set; }
        public string Apartment { get; set; }

        public virtual IEnumerable<LessePeriod> LessePeriods { get; set; }
        public virtual IEnumerable<Property> Properties { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
