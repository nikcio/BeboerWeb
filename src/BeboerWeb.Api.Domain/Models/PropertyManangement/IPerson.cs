using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface IPerson
    {
        IEnumerable<Employee> Employees { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        IEnumerable<Tenant> Tenants { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }
    }
}