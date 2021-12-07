using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Models.DTOs.PropertyManagement;
using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.Chat
{
    public class TenantToEmployeeMessageDto
    {
        public int Id { get; set; }

        public virtual TenantDto Sender { get; set; }

        public virtual IEnumerable<EmployeeDto> Receivers { get; set; }

        public string TimeStamp { get; set; }
        
        public string MessageText { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
