using BeboerWeb.Api.Domain.Models.Chat;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface IEmployee : IPerson
    {
        public IEnumerable<Company> Companies { get; set; }
        IEnumerable<TenantToEmployeeMessage> TenantToEmployeeMessages { get; set; }
    }
}