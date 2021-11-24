using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Domain.Models.Chat;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface ITenant : IPerson
    {
        public double Balance { get; set; }

        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<LeasePeriod> LeasePeriods { get; set; }
        IEnumerable<TenantToTenantMessage> ReceivedInternalMessages { get; set; }
        IEnumerable<EmployeeToTenantMessage> EmployeeToTenantMessages { get; set; }
        IEnumerable<TenantToTenantMessage> SentInternalMessages { get; set; }
    }
}