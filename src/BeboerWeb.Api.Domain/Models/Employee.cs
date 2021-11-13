using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }

        public virtual IPerson Person { get; set; }
        public virtual IEnumerable<ICompany> Companies { get; set; }
    }
}
