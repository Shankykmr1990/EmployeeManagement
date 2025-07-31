namespace EmployeeManagement.Models
{
    public class Department
    {
        //One to Many Relationship
        public int DepartmentId { get; set; } // PrimaryKey
        public string Name { get; set; }
        
        //Relationship with Employees
        public List<Employee> Employees { get; set; }
    }
}
