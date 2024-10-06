using AutoMapper;
using LeaveManage.web.Constant;
using LeaveManage.web.Data;
using LeaveManage.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace LeaveManage.web.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _model;
        public EmployeesController(UserManager<Employee> userManager, IMapper model)
        {
            _userManager = userManager;
            _model = model;

        }
        // GET: EmployeesController
        public async Task<ActionResult> Index()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.Administrator);
            var empviewmodel = _model.Map<List<EmployeeListVM>>(employees);
            return View(empviewmodel);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
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

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
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
