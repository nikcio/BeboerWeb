using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public interface IBookingService : ICrudServiceBase<Booking, IBookingRepository>
    {
    }
}