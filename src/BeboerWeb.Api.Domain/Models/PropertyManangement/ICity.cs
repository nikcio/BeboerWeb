using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ICity
    {
        IEnumerable<Address> Addresses { get; set; }
        Country Country { get; set; }
        string Name { get; set; }
        string Zipcode { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }
    }
}