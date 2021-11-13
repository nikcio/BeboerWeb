using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Address : IAddress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public virtual IEnumerable<Property> Properties { get; set; }
        public virtual City City { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
