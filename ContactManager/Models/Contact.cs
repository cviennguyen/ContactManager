using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a email")]
        public string? Email { get; set; }

        public string? Organization { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1,10, ErrorMessage = "Please select a category")]
        public int CategoryId { get; internal set; }
        public Category? Category { get; set; }

        public String Slug => Firstname?.Replace(' ', '-').ToLower() + '-' + Lastname?.Replace(' ', '-').ToLower();
    }
}
