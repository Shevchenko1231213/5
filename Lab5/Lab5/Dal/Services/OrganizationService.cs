using Dapper;
using Lab5.Dal.Data;
using Lab5.Models;
using System.Collections.Generic;

namespace Lab5.Dal.Services
{
    public class OrganizationService
    {
        public IEnumerable<Organization> GetAllOrganizations()
        {
            using (var connection = DatabaseConnection.CreateConnection())
            {
                return connection.Query<Organization>("SELECT * FROM Organization");
            }
        }

        public void AddOrganization(Organization organization)
        {
            using (var connection = DatabaseConnection.CreateConnection())
            {
                connection.Execute("INSERT INTO Organization (Name, DirectorPIB, DeputyDirectorPIB, DepartmentId) VALUES(@Name, @DirectorPIB, @DeputyDirectorPIB, @DepartmentId)", organization);
            }
        }

        public IEnumerable<Organization> GetOrganizationByName(string name)
        {
            using (var connection = DatabaseConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM Organization WHERE Name = {name}";
                return connection.Query<Organization>(sql);
            }
        }
    }
}
