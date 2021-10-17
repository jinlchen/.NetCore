using EmployeeManagement3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement3.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _EmployeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }
        public ViewResult index()
        {
            //return Json(new {Id=1,Name="James" });
            //return "from Home controller index.";
            return View(_EmployeeRepository.getList());
        }
        public ViewResult detail(int? id)
        {
            return View(_EmployeeRepository.GetEmployee(id??1));
        }
        [HttpGet]
        public ViewResult create()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult create(Employee e)
        {
            _EmployeeRepository.create(e);
            return RedirectToAction("index", "home");
        }
    }
}
