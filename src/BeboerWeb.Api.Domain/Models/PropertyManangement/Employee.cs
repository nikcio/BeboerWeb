using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public virtual IEnumerable<Company> Companies { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
