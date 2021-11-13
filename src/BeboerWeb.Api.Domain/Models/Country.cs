using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Country
    {
        public string Name { get; set; }

        public virtual IEnumerable<City> Cities { get; set; }
    }
}
