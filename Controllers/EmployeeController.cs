using EmployeeManagement.Models;
using EmployeeManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<Department> departmentList = new List<Department>
            {
                new Department{DepartmentId=1,Name="IT"},
                new Department{DepartmentId=2,Name="HR" }
            };
            ViewBag.Departments = new SelectList(departmentList, "DepartmentId", "Name");
            return View();  
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel evm)
        {
            if (!ModelState.IsValid)
            {
                return View(evm);
            }
            return View(evm);
        }
    }
}
