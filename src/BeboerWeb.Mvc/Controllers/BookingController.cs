using BeboerWeb.Mvc.Integrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers.Administration.Bookings.BookingItems
{
    public class BookingController : Controller
    {
        private readonly ApiClient apiClient;
        private readonly ILogger<BookingController> logger;

        public BookingController(ApiClient apiClient, ILogger<BookingController> logger)
        {
            this.apiClient = apiClient;
            this.logger = logger;
        }

        // GET: BookingController
        public async Task<ActionResult> Index()
        {
            ViewBag.BookingItems = await apiClient.GetAllBookingItemAsync();
            return View(await apiClient.GetAllBookingAsync());
        }

        // GET: BookingController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await apiClient.GetBookingAsync(id);
            ViewBag.BookingItem = await apiClient.GetBookingItemAsync(model.BookingItemId);
            return View(model);
        }

        // GET: BookingController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.BookingItems = await apiClient.GetAllBookingItemAsync();
            return View();
        }

        // POST: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] BookingDto bookingDto)
        {
            try
            {
                await apiClient.AddBookingAsync(bookingDto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.BookingItems = await apiClient.GetAllBookingItemAsync();
                logger.LogError(e, "create failed");
                ModelState.AddModelError("Fejl", "Der skete en fejl prøv igen.");
                return View();
            }
        }

        // GET: BookingController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ViewBag.BookingItems = await apiClient.GetAllBookingItemAsync();
            return View(await apiClient.GetBookingAsync(id));
        }

        // POST: BookingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] BookingDto bookingDto)
        {
            try
            {
                await apiClient.UpdateBookingAsync(id, bookingDto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.BookingItems = await apiClient.GetAllBookingItemAsync();
                logger.LogError(e, "edit failed");
                ModelState.AddModelError("Fejl", "Der skete en fejl prøv igen");
                return View(await apiClient.GetBookingAsync(id));
            }
        }

        // GET: BookingController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var model = await apiClient.GetBookingAsync(id);
            ViewBag.BookingItem = await apiClient.GetBookingItemAsync(model.BookingItemId);
            return View(model);
        }

        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, [FromForm] BookingDto bookingDto)
        {
            try
            {
                await apiClient.DeleteBookingAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                var model = await apiClient.GetBookingAsync(id);
                ViewBag.BookingItem = await apiClient.GetBookingItemAsync(model.BookingItemId);
                logger.LogError(e, "Delete failed");
                ModelState.AddModelError("Fejl", "Der skete en fejl prøv igen");
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IEnumerable<BookingWindowDto>> GetBookingWindowInformation(int bookingItemId)
        {
            return await apiClient.GetAllBookingWindowsForBookingItemBookingWindowAsync(bookingItemId);
        }

        [HttpGet]
        public async Task<BookingItemBookingsDto> GetExistingBookings(int bookingItemid)
        {
            return await apiClient.GetAllBookingsBookingItemAsync(bookingItemid);
        }
    }
}
