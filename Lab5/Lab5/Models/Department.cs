namespace Lab5.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SupervisorPIB { get; set; }
        public string DeputySupervisorPIB { get; set; }
        public string SpecialistPIB { get; set; }
        public string EmployeePIB { get; set; }
    }
}
