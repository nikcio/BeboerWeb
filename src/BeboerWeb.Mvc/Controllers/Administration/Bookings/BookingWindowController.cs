using BeboerWeb.Mvc.Authorization.Constants;
using BeboerWeb.Mvc.Integrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers.Administration.Bookings.BookingItems
{
    [Authorize(Policy = Policies.EmployeeOnly)]
    public class BookingWindowController : Controller
    {
        private readonly ApiClient apiClient;
        private readonly ILogger<BookingWindowController> logger;

        public BookingWindowController(ApiClient apiClient, ILogger<BookingWindowController> logger)
        {
            this.apiClient = apiClient;
            this.logger = logger;
        }

        // GET: BookingController
        public async Task<ActionResult> Index()
        {
            return View(await apiClient.GetAllBookingWindowAsync());
        }

        // GET: BookingController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await apiClient.GetBookingWindowAsync(id));
        }

        // GET: BookingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] BookingWindowDto bookingWindowDto)
        {
            try
            {
                await apiClient.AddBookingWindowAsync(bookingWindowDto);
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
            return View(await apiClient.GetBookingWindowAsync(id));
        }

        // POST: BookingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] BookingWindowDto bookingWindowDto)
        {
            try
            {
                await apiClient.UpdateBookingWindowAsync(id, bookingWindowDto);
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
            return View(await apiClient.GetBookingWindowAsync(id));
        }

        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, [FromForm] BookingWindowDto bookingWindowDto)
        {
            try
            {
                await apiClient.DeleteBookingWindowAsync(id);
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
