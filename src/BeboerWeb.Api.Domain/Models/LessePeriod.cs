using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class LessePeriod : ILessePeriod
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<ITenant> Tenants { get; set; }
        public ILesse Lesse { get; set; }
    }
}
