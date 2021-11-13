using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class City : ICity
    {
        public string Name { get; set; }
        public string Zipcode { get; set; }

        public virtual IEnumerable<IAddress> Addresses { get; set; }
        public virtual ICountry Country { get; set; }
    }
}
