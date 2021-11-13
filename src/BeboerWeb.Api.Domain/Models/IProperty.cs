using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public interface IProperty
    {
        IEnumerable<IAddress> Addresses { get; set; }
        IEnumerable<ICompany> Companies { get; set; }
        IEnumerable<ILesse> Lesses { get; set; }
    }
}