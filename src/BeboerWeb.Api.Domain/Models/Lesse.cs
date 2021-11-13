using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Lesse : ILesse
    {
        public int Id { get; set; }
        public int Story { get; set; }
        public string Apartment { get; set; }

        public virtual IEnumerable<ILessePeriod> LessePeriods { get; set; }
        public virtual IEnumerable<IProperty> Properties { get; set; }
    }
}
