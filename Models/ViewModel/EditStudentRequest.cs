using System.ComponentModel.DataAnnotations;

namespace test_apps_3.Models.ViewModel
{
    public class EditStudentRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? session { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Date { get; set; }

        // To display the current image in the view
        public byte[]? ProfilePicture { get; set; }

        // To capture a new upload
        [Display(Name = "Update Picture")]
        public IFormFile? ProfileImage { get; set; }
    }
}