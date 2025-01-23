using System.ComponentModel.DataAnnotations;
using TestingProject.Validation;

namespace TestingProject.ViewModel
{
    public class Author
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        [IsEmpty(ErrorMessage = "Should not be null or empty.")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Html)]
        
        public string Html { get; set; }

        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
