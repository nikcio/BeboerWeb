﻿using System;
using System.Collections.Generic;

namespace BeboerWeb.Api.Models.DTOs.Bookings
{
    public class BookingDto
    {
        public int Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int BookingItemId { get; set; }
        public int TenantId { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
