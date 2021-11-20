using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class City : ICity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Zipcode { get; set; }

        public virtual IEnumerable<Address> Addresses { get; set; }
        public virtual Country Country { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
