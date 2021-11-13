using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Company
    {
        public virtual IEnumerable<Property> Properties { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<Employee> Owners { get; set; }
    }
}
