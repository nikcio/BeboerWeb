﻿using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bookings;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Controllers.Bookings
{
    [Route("api/bookings/bookingwindow")]
    [ApiController]
    public class BookingWindowController : CrudControllerBase<BookingWindowDto, BookingWindow, IBookingWindowRepository, IBookingWindowService>
    {
        public BookingWindowController(IBookingWindowService service, IMapper mapper) : base(service, mapper)
        {
        }

        [HttpGet("GetAllBookingWindowsForBookingItem/{bookingItemId}")]
        public virtual async Task<ActionResult<IEnumerable<BookingWindowDto>>> GetAllBookingWindowsForBookingItem(int bookingItemId)
        {
            var serviceResponse = await service.GetAllBookingWindowsForBookingItem(bookingItemId);
            return CreateResponse<IEnumerable<BookingWindow>, IEnumerable<BookingWindowDto>>(serviceResponse);
        }
    }
}
