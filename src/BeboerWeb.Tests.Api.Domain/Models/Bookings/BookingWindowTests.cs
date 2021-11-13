using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Tests.Api.Domain.Models.Bookings
{
    [TestClass]
    public class BookingWindowTests
    {
        [DataTestMethod]
        [DataRow(1, 4, 2, 3)]
        [DataRow(1, 4, 1, 4)]
        [DataRow(1, 4, 1, 2)]
        [DataRow(1, 4, 3, 4)]
        public void IsBookingInBookingWindow_Should_Pass(int windowStartTimeOffSet, int windowEndTimeOffset,
            int newBookingStartTimeOffSet, int newBookingEndTimeOffset)
        {
            var result = IsBookingInBookingWindow_Test(windowStartTimeOffSet, windowEndTimeOffset, newBookingStartTimeOffSet, newBookingEndTimeOffset);
        
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(1, 4, 2, 5)]
        [DataRow(1, 4, -1, 3)]
        public void IsBookingInBookingWindow_Should_not_Pass(int windowStartTimeOffSet, int windowEndTimeOffset,
            int newBookingStartTimeOffSet, int newBookingEndTimeOffset)
        {
            var result = IsBookingInBookingWindow_Test(windowStartTimeOffSet, windowEndTimeOffset, newBookingStartTimeOffSet, newBookingEndTimeOffset);

            Assert.IsFalse(result);
        }

        private bool IsBookingInBookingWindow_Test(int windowStartTimeOffSet, int windowEndTimeOffset,
            int newBookingStartTimeOffSet, int newBookingEndTimeOffset)
        {
            var dateTimeNow = DateTime.Now;
            var window = new BookingWindow { StartTime = dateTimeNow.AddMinutes(windowStartTimeOffSet), EndTime = dateTimeNow.AddMinutes(windowEndTimeOffset) };
            var newBooking = new Booking { StartTime = dateTimeNow.AddMinutes(newBookingStartTimeOffSet), EndTime = dateTimeNow.AddMinutes(newBookingEndTimeOffset) };

            var result = window.IsBookingInBookingWindow(newBooking);
            return result;
        }
    }
}
