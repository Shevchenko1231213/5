using Lab5.Dal.Facade;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly Facade _facade;

        public DepartmentController(Facade facade)
        {
            _facade = facade;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var result = _facade.GetAllDepartments();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddDepartment(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [HttpPost]
        public string AddDepartment(Department department)
        {
            _facade.AddDepartment(department);
            return "Department," + department.Name + ",Added";
        }

        [HttpGet]
        public IActionResult GetByName(string name)
        {
            var result = _facade.GetDepartmentByName(name);
            return View(result);
        }
    }
}
