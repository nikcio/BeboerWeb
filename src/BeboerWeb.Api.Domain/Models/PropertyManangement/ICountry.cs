using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ICountry
    {
        IEnumerable<City> Cities { get; set; }
        string Name { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }
    }
}