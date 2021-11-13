using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<Tenant> Tenants { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
