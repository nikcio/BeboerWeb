using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface IEmployee
    {
        IEnumerable<Company> Companies { get; set; }
        int Id { get; set; }
        Person Person { get; set; }
        byte[] RowVersion { get; set; }
    }
}