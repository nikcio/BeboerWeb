using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Company : ICompany
    {
        public int Id { get; set; }
        public virtual IEnumerable<Property> Properties { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<Employee> Owners { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
