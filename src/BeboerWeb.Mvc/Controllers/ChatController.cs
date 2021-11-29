using BeboerWeb.Mvc.Integrations;
using BeboerWeb.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;
        private readonly ApiClient apiClient;

        public ChatController(ILogger<ChatController> logger, ApiClient apiClient)
        {
            _logger = logger;
            this.apiClient = apiClient;
        }

        public async Task<ActionResult> ChatWindow()
        {
            return View();
        }

        public async Task<IEnumerable<EmployeeToTenantMessageDto>> GetEmployeeToTenantMessages()
        {
            return await apiClient.GetAllEmployeeToTenantMessageAsync();
        }
        public async Task<IEnumerable<TenantToEmployeeMessageDto>> GetTenantToEmployeeMessage()
        {
            return await apiClient.GetAllTenantToEmployeeMessageAsync();
        }
        public async Task<IEnumerable<TenantToTenantMessageDto>> GetTenantToTenantMessage()
        {
            return await apiClient.GetAllTenantToTenantMessageAsync();
        }
    }
}
