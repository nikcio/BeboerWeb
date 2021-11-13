using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<Tenant> Tenants { get; set; }
    }
}
