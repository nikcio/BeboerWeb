using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Property : IProperty
    {
        public int Id { get; set; }
        public virtual IEnumerable<Lesse> Lesses { get; set; }
        public virtual IEnumerable<Address> Addresses { get; set; }
        public virtual IEnumerable<Company> Companies { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
