using MVCWebTest.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebTest.Controllers
{
    public class HomeController : Controller
    {
        EmployeeService service = new EmployeeService();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Button()
        {
            var list = service.GetAll();
            ViewBag.list = list;
            return View();
        }

        public ActionResult Edit(int id)
        {
            var emp = service.GetById(id);
            ViewBag.Employee = emp;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, string FullName)
        {
            var emp = service.editEmployee(id, FullName);
            return RedirectToAction("Button");
        }

    }
}