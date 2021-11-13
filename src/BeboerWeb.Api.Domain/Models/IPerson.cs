using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface IPerson
    {
        IEnumerable<IEmployee> Employees { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        IEnumerable<ITenant> Tenants { get; set; }
    }
}