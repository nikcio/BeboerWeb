using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ICompany
    {
        IEnumerable<Employee> Employees { get; set; }
        IEnumerable<Employee> Owners { get; set; }
        IEnumerable<Property> Properties { get; set; }
        byte[] RowVersion { get; set; }
        int Id { get; set; }
    }
}