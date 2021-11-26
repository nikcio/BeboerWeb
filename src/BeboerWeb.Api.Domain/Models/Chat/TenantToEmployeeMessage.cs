using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Chat
{
    public class TenantToEmployeeMessage : ITenantToEmployeeMessage
    {
        public int Id { get; set; }

        public virtual Tenant Sender { get; set; }

        public virtual IEnumerable<Employee> Receivers { get; set; }

        public DateTime TimeStamp { get; set; }

        public string MessageText { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
