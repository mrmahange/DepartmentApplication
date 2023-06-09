namespace DepartmentApp.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(int departmentID, string? name)
        {
            DepartmentID = departmentID;
            Name = name;
            Employees = new List<Employee>();
        }
    }
}
