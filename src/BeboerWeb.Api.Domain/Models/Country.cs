using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Country : ICountry
    {
        public string Name { get; set; }

        public virtual IEnumerable<ICity> Cities { get; set; }
    }
}
