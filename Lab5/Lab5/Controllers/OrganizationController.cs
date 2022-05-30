using Lab5.Dal.Facade;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly Facade _facade;

        public OrganizationController(Facade facade)
        {
            _facade = facade;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllOrganizations()
        {
            var result = _facade.GetAllOrganizations();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddOrganization(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [HttpPost]
        public string AddOrganization(Organization organization)
        {
            _facade.AddOrganization(organization);
            return "Organization," + organization.Name + ",Added";
        }

        [HttpGet]
        public IActionResult GetByName(string name)
        {
            var result = _facade.GetOrganizationByName(name);
            return View(result);
        }
    }
}
