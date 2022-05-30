using Lab5.Dal.Services;
using Lab5.Models;
using System.Collections.Generic;

namespace Lab5.Dal.Facade
{
    public class Facade
    {
        private readonly OrganizationService _organizationService;
        private readonly DepartmentService _departmentService;

        public Facade()
        {
            _organizationService = new OrganizationService();
            _departmentService = new DepartmentService();
        }

        public IEnumerable<Organization> GetAllOrganizations()
        {
            return _organizationService.GetAllOrganizations();
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentService.GetAllDepartments();
        }

        public void AddDepartment(Department department)
        {
            _departmentService.AddDepartment(department);
        }

        public void AddOrganization(Organization organization)
        {
            _organizationService.AddOrganization(organization);
        } 

        public IEnumerable<Organization> GetOrganizationByName(string name)
        {
            return _organizationService.GetOrganizationByName(name);
        }

        public IEnumerable<Department> GetDepartmentByName(string name)
        {
            return _departmentService.GetDepartmentByName(name);
        }
    }
}
