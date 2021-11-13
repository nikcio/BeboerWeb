using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface ICountry
    {
        IEnumerable<ICity> Cities { get; set; }
        string Name { get; set; }
    }
}