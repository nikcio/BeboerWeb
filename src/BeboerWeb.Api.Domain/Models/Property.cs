using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Property : IProperty
    {
        public virtual IEnumerable<ILesse> Lesses { get; set; }
        public virtual IEnumerable<IAddress> Addresses { get; set; }
        public virtual IEnumerable<ICompany> Companies { get; set; }
    }
}
