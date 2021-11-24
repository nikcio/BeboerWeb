using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Chat
{
    public class EmployeeToTenantMessage : IEmployeeToTenantMessage
    {
        public int Id { get; set; }

        public virtual Employee Sender { get; set; }

        public virtual IEnumerable<Tenant> Receivers { get; set; }

        public DateTime TimeStamp { get; set; }

        public string MessageText { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
