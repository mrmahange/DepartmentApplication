namespace DepartmentApp.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public Employee(int empID, string? firstname, string? lastname)
        {
            EmpID = empID;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
