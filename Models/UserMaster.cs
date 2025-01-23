using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TestingProject.Models
{
    public class UserMaster
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Create Date is required")]
        public DateTime CreateDate { get; set; }
    }
}
