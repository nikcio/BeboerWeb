using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface IAddress
    {
        ICity City { get; set; }
        string Number { get; set; }
        IEnumerable<IProperty> Properties { get; set; }
        string Street { get; set; }
    }
}