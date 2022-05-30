namespace Lab5.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DirectorPIB { get; set; }
        public string DeputyDirectorPIB { get; set; }
        public int DepartmentId { get; set; }
    }
}
