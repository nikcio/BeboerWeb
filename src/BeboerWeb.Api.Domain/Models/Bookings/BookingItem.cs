﻿namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public class BookingItem : IBookingItem
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
