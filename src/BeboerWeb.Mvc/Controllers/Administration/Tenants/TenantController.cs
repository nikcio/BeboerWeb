using BeboerWeb.Mvc.Integrations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BeboerWeb.Mvc.Controllers.Administration.Tenants
{
    public class TenantController : Controller
    {
        private readonly ApiClient apiClient;

        public TenantController(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // GET: TenantController
        public async Task<ActionResult> Index()
        {
            return View(await apiClient.GetAllTenantAsync());
        }

        // GET: TenantController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await apiClient.GetTenantAsync(id));
        }

        // GET: Tenant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TenantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] TenantDto tenantDto)
        {
            try
            {
                await apiClient.AddTenantAsync(tenantDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TenantController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await apiClient.GetTenantAsync(id));
        }

        // POST: TenantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] TenantDto tenantDto)
        {
            try
            {
                await apiClient.UpdateTenantAsync(id, tenantDto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                return View();
            }
        }

        // GET: TenantController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await apiClient.GetTenantAsync(id));
        }

        // POST: TenantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, TenantDto tenantDto)
        {
            try
            {
                await apiClient.DeleteTenantAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
