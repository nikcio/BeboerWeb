using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Shared.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Persistence.Repositories
{
    public interface ICompanyRepository : IRepository, ICrudRepository<ICompany>
    {
    }
}
