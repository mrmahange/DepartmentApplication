using DepartmentApp.Models;

namespace DepartmentApp.Data
{
    /// <summary>
    /// Class to store Department and Employee Lists
    /// </summary>
    public static class DataStore
    {    
        public static List<Department>? Departments { get; set; } =
            new List<Department>() { 
            new Department(1,"IT"),
            new Department(2,"HR"),
            new Department(3,"FINANCE"),
            new Department(3,"LIBRARY"),
            new Department(3,"CUSTOMER RELATIONS"),
            };
    }
}
