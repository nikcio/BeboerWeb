using BeboerWeb.Api.Domain.Models.PropertyManangement;
using System.Collections.Generic;
using System;

namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class LessePeriodDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
