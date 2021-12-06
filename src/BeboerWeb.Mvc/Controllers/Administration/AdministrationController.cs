using BeboerWeb.Mvc.Authorization.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Mvc.Controllers.Administration
{
    [Authorize(Policy = Policies.EmployeeOnly)]
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
