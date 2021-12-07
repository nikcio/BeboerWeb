using AutoMapper;
using BeboerWeb.Mvc.Authorization.Constants;
using BeboerWeb.Mvc.Integrations;
using BeboerWeb.Mvc.Models;
using BeboerWeb.Mvc.Models.ExtraDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers
{
    [Authorize(Policy = Policies.ActiveTenantOnly)]
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;
        private readonly ApiClient apiClient;
        private readonly IMapper mapper;

        public ChatController(ILogger<ChatController> logger, ApiClient apiClient, IMapper mapper)
        {
            _logger = logger;
            this.apiClient = apiClient;
            this.mapper = mapper;
        }

        public ActionResult ChatWindow()
        {
            return View();
        }

        [HttpPost]
        public async Task SendEmployeeToTenantMessage([FromBody] MessageDto message)
        {
            var employeeMessage = mapper.Map<EmployeeToTenantMessageDto>(message);
            await apiClient.AddEmployeeToTenantMessageAsync(employeeMessage);
        }

        public async Task<IEnumerable<MessageDto>> GetEmployeeToTenantMessages(int employeeId)
        {
            var recevied = await apiClient.GetAllForReceiverTenantToEmployeeMessageAsync(employeeId);
            var sent = await apiClient.GetAllForSenderEmployeeToTenantMessageAsync(employeeId);
            
            var recevied2 = mapper.Map<IEnumerable<MessageDto>>(recevied);
            var sent2 = mapper.Map<IEnumerable<MessageDto>>(sent);

            var allMessages = recevied2.Concat(sent2).OrderBy(x => DateTime.Parse(x.TimeStamp, new CultureInfo("da-DK")));
            return allMessages;
        }
        public async Task<IEnumerable<TenantToEmployeeMessageDto>> GetTenantToEmployeeMessage(int receiverId, int senderId)
        {
            var recevied = await apiClient.GetAllForReceiverTenantToEmployeeMessageAsync(receiverId);
            var sent = await apiClient.GetAllForSenderTenantToEmployeeMessageAsync(senderId);
            var allMessages = recevied
                .Concat(sent)
                .Where(item =>
                    item.Receivers.Any(recevier => recevier.Id == receiverId))
                .Distinct()
                .OrderBy(x => x.TimeStamp);
            return allMessages;
        }
        public async Task<IEnumerable<TenantToTenantMessageDto>> GetTenantToTenantMessage(int receiverId, int senderId)
        {
            var recevied = await apiClient.GetAllForReceiverTenantToTenantMessageAsync(receiverId);
            var sent = await apiClient.GetAllForSenderTenantToTenantMessageAsync(senderId);
            var allMessages = recevied
                .Concat(sent)
                .Where(item =>
                    item.Receivers.Any(recevier => recevier.Id == receiverId))
                .Distinct();
            return allMessages;
        }
    }
}
