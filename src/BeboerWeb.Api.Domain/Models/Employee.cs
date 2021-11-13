using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public virtual Person Person { get; set; }
        public virtual IEnumerable<Company> Companies { get; set; }
    }
}
