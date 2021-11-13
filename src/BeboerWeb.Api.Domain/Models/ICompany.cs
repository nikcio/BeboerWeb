using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface ICompany
    {
        IEnumerable<IEmployee> Employees { get; set; }
        System.Collections.Generic.IEnumerable<IEmployee> Owners { get; set; }
        System.Collections.Generic.IEnumerable<IProperty> Properties { get; set; }
    }
}