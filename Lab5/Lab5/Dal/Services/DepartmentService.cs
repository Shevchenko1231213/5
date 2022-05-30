using Dapper;
using Lab5.Dal.Data;
using Lab5.Models;
using System.Collections.Generic;

namespace Lab5.Dal.Services
{
    public class DepartmentService
    {
        public IEnumerable<Department> GetAllDepartments()
        {
            using (var connection = DatabaseConnection.CreateConnection())
            {
                return connection.Query<Department>("SELECT * FROM Department");
            }
        }

        public void AddDepartment(Department department)
        {
            using (var connection = DatabaseConnection.CreateConnection())
            {
                connection.Execute("INSERT INTO Department (Name, SupervisorPIB, DeputySupervisorPIB, SpecialistPIB, EmployeePIB) VALUES(@Name, @SupervisorPIB, @DeputySupervisorPIB, @SpecialistPIB, @EmployeePIB)", department);
            }
        }

        public IEnumerable<Department> GetDepartmentByName(string name)
        {
            using (var connection = DatabaseConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM Department WHERE Name = {name}";
                return connection.Query<Department>(sql);
            }
        }
    }
}
