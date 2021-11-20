using System;

namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class LeasePeriodDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
