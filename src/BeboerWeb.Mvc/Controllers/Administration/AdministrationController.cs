using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Mvc.Controllers.Administration
{
    public class AdministrationController : Controller
    {
        private readonly ILogger<AdministrationController> _logger;

        public AdministrationController(ILogger<AdministrationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
