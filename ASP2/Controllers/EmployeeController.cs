using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;
using System.Collections.Generic;
using ASP2.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>();

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Id = employees.Count + 1;
                employees.Add(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }
    }
}
