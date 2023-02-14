﻿using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class ServiceTypeController : Controller
    {

        private readonly IServiceTypeService _serviceTypeService;

        public ServiceTypeController(IServiceTypeService serviceTypeService)
        {
            this._serviceTypeService = serviceTypeService;
        }
        public async Task<IActionResult> Index()
        {
            var val = await _serviceTypeService.GetAllAsync();
            return View(val);
        }

        // GET: serviceTypeController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var val = await _serviceTypeService.FindAsync(id);
            return View(val);
        }

        // GET: serviceTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: serviceTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceType serviceType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _serviceTypeService.InsertAsync(serviceType);
                }
                TempData["successAlert"] = "serviceType  save successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: serviceTypeController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var val = await _serviceTypeService.FindAsync(id);
            return View(val);
        }

        // POST: IndustialTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ServiceType serviceType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _serviceTypeService.UpdateAsync(serviceType);
                }

                TempData["successAlert"] = "serviceType update successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: serviceTypeController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var val = await _serviceTypeService.FindAsync(id);
            return View(val);
        }

        // POST: serviceTypeController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            try
            {
                var val = await _serviceTypeService.FindAsync(id);
                if (val != null)
                {
                    await _serviceTypeService.DeleteAsync(val);
                }
                TempData["successAlert"] = "serviceType delete successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}