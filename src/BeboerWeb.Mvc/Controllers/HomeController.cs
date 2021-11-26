using BeboerWeb.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DocumentArchive()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult DocumentLease()
        {
            return View();
        }
        public IActionResult DocumentRules()
        {
            return View();
        }
        public IActionResult DocumentPaidBills()
        {
            return View();
        }
        public IActionResult DocumentsComplaints()
        {
            return View();
        }
        public IActionResult DocumentsRentAdjustment()
        {
            return View();
        }
  
        public IActionResult documentoccupancyevictionreport()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
