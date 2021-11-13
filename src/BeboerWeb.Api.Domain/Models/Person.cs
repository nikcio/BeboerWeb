using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual IEnumerable<IEmployee> Employees { get; set; }
        public virtual IEnumerable<ITenant> Tenants { get; set; }
    }
}
