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
    public class BookingTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 3, 4)]
        [DataRow(3, 4, 1, 2)]
        public void IsOverlapping_should_pass(int currentBookingStartTimeOffSet, int currentEndTimeOffset,
            int newStartTimeOffSet, int newStartTimeOffset)
        {
            bool result = IsOverLappingTest(currentBookingStartTimeOffSet, currentEndTimeOffset, newStartTimeOffSet, newStartTimeOffset);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 1, 2)]
        [DataRow(1, 3, 2, 3)]
        [DataRow(3, 5, 1, 4)]
        [DataRow(3, 4, 1, 3)]
        [DataRow(1, 2, 2, 3)]
        [DataRow(3, 4, 2, 3)]
        public void IsOverlapping_should_not_pass(int currentBookingStartTimeOffSet, int currentEndTimeOffset,
            int newStartTimeOffSet, int newStartTimeOffset)
        {
            bool result = IsOverLappingTest(currentBookingStartTimeOffSet, currentEndTimeOffset, newStartTimeOffSet, newStartTimeOffset);

            Assert.IsFalse(result);
        }

        private static bool IsOverLappingTest(int currentBookingStartTimeOffSet, int currentEndTimeOffset, int newStartTimeOffSet, int newStartTimeOffset)
        {
            var dateTimeNow = DateTime.Now;
            var booking = new Booking { StartTime = dateTimeNow.AddMinutes(currentBookingStartTimeOffSet), EndTime = dateTimeNow.AddMinutes(currentEndTimeOffset) };
            var newBooking = new Booking { StartTime = dateTimeNow.AddMinutes(newStartTimeOffSet), EndTime = dateTimeNow.AddMinutes(newStartTimeOffset) };

            var result = booking.IsOverlapping(newBooking);
            return result;
        }
    }
}
