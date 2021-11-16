﻿using BeboerWeb.Mvc.Integrations;
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

        public ApiClient ApiClient { get; }

        public HomeController(ILogger<HomeController> logger, ApiClient apiClient)
        {
            _logger = logger;
            ApiClient = apiClient;
        }

        public async Task<IActionResult> Index()
        {
            var a = await ApiClient.GetAllAddressAsync();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
