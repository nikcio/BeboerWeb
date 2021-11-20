using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Country : ICountry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<City> Cities { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
