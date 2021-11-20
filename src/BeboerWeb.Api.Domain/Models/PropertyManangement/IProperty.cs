using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface IProperty
    {
        IEnumerable<Address> Addresses { get; set; }
        IEnumerable<Company> Companies { get; set; }
        IEnumerable<Lease> Lesses { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }
    }
}