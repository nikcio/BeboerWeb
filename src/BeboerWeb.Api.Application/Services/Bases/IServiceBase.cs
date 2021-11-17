using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;
using System.Threading.Tasks;
using System;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public interface IServiceBase<TRepository> : IUnitOfWork<TRepository>
        where TRepository : IRepository
    {
    }
}