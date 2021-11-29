using BeboerWeb.Mvc.Integrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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
            return View(await apiClient.GetAllBookingAsync());
        }

        // GET: BookingController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await apiClient.GetBookingAsync(id));
        }

        // GET: BookingController/Create
        public ActionResult Create()
        {
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
                logger.LogError(e, "create failed");
                return View();
            }
        }

        // GET: BookingController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
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
                logger.LogError(e, "edit failed");
                return View();
            }
        }

        // GET: BookingController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await apiClient.GetBookingAsync(id));
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
                logger.LogError(e, "Delete failed");
                return View();
            }
        }
    }
}
