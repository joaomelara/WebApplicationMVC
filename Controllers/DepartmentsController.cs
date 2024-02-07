using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationMVC.Models.ViewModel;

namespace WebApplicationMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Games"});
            departments.Add(new Department { Id = 2, Name = "Consoles" });
            return View(departments);
        }
    }
}
