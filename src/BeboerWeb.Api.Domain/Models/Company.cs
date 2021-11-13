using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Company : ICompany
    {
        public virtual IEnumerable<IProperty> Properties { get; set; }
        public virtual IEnumerable<IEmployee> Employees { get; set; }
        public virtual IEnumerable<IEmployee> Owners { get; set; }
    }
}
