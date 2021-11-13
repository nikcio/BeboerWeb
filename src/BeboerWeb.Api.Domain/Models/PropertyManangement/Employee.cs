using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }

        public virtual Person Person { get; set; }
        public virtual IEnumerable<Company> Companies { get; set; }
        public virtual IEnumerable<Company> OwnedCompanies { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
