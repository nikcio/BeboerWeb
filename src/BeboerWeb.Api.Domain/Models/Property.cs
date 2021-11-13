using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Property
    {
        public virtual IEnumerable<Lesse> Lesses { get; set; }
        public virtual IEnumerable<Address> Addresses { get; set; }
        public virtual IEnumerable<Company> Companies { get; set; }
    }
}
