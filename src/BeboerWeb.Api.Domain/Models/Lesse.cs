using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Lesse
    {
        public int Id { get; set; }
        public int Story { get; set; }
        public string Apartment { get; set; }

        public virtual IEnumerable<LessePeriod> LessePeriods { get; set; }
        public virtual IEnumerable<Property> Properties { get; set; }
    }
}
