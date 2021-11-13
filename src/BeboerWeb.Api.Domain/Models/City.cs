using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Zipcode { get; set; }

        public virtual IEnumerable<Address> Addresses { get; set; }
        public virtual Country Country { get; set; }
    }
}
