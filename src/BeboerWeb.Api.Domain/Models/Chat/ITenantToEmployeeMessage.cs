using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Chat
{
    public interface ITenantToEmployeeMessage
    {
        int Id { get; set; }
        string MessageText { get; set; }
        IEnumerable<Employee> Receivers { get; set; }
        byte[] RowVersion { get; set; }
        Tenant Sender { get; set; }
        DateTime TimeStamp { get; set; }
    }
}