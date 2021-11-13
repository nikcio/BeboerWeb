using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface IAddress
    {
        City City { get; set; }
        string Number { get; set; }
        IEnumerable<Property> Properties { get; set; }
        string Street { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }
    }
}