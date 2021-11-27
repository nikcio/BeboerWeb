using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class BookingService : CrudServiceBase<Booking, IBookingRepository>, IBookingService
    {
        public BookingService(IBookingRepository repository, ILogger<ServiceBase<IBookingRepository>> logger) : base(repository, logger)
        {
        }

        public async override Task<IServiceResponse<Booking>> Add(Booking entity)
        {
            if (await repository.IsBookingVaild(entity))
            {
                return await base.Add(entity);
            }
            else
            {
                return new ServiceResponse<Booking>(StatusCode.BadRequest, null);
            }
        }

        public async override Task<IServiceResponse<Booking>> Update(Booking entity)
        {
            if (await repository.IsBookingVaild(entity))
            {
                return await base.Update(entity);
            }
            else
            {
                return new ServiceResponse<Booking>(StatusCode.BadRequest, null);
            }
        }
    }
}
