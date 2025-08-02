using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModel
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department Name is Required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string Name { get; set; }
    }
}
