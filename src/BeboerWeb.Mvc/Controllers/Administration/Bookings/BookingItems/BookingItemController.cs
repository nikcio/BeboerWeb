using BeboerWeb.Mvc.Integrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers.Administration.Bookings.BookingItems
{
    public class BookingItemController : Controller
    {
        private readonly ApiClient apiClient;

        public BookingItemController(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // GET: BookingController
        public async Task<ActionResult> Index()
        {
            return View(await apiClient.GetAllBookingItemAsync());
        }

        // GET: BookingController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await apiClient.GetBookingItemAsync(id));
        }

        // GET: BookingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] BookingItemDto bookingItemDto)
        {
            try
            {
                await apiClient.PostBookingItemAsync(bookingItemDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await apiClient.GetBookingItemAsync(id));
        }

        // POST: BookingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await apiClient.GetBookingItemAsync(id));
        }

        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
