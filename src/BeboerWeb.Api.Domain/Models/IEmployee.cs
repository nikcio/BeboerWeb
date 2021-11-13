using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface IEmployee
    {
        IEnumerable<ICompany> Companies { get; set; }
        int Id { get; set; }
        IPerson Person { get; set; }
    }
}