using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface ICity
    {
        IEnumerable<IAddress> Addresses { get; set; }
        ICountry Country { get; set; }
        string Name { get; set; }
        string Zipcode { get; set; }
    }
}