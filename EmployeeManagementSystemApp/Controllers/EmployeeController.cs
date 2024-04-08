using EmployeeManagementSystemApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagementSystemApp.Controllers
{
    public class EmployeeController : Controller
    {
        private object _employeeRepository;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View(new Employee());
        }
        public IActionResult Edit()
        {
            return View(new Employee());
        }
        public IActionResult Details()
        {
            return View(new Employee());
        }

        public IActionResult Delete()
        {
            return View(new Employee());
        }
        /* [HttpPost]
         public IActionResult Delete(int id)
         {

             var employee = _employeeRepository.GetById(id);

             if (employee == null)
             {
                 return NotFound();
             }            
             _employeeRepository.Delete(employee);

             return RedirectToAction("Index");
         }*/
    }
}
