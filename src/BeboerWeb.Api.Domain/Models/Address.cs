using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Address : IAddress
    {
        public string Street { get; set; }
        public string Number { get; set; }

        public virtual IEnumerable<IProperty> Properties { get; set; }
        public virtual ICity City { get; set; }
    }
}
