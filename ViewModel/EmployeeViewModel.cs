using EmployeeManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(10, ErrorMessage = "Last Name cannot exceed 10 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Date of Birth is Required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Not a valid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [Phone(ErrorMessage = "Phone Number not in format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address is Reuired")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Address is Reuired")]
        public bool IsActive { get; set; }

        // Forign Key
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
