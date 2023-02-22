using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exercise2.Models
{
    public class Contacts
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter a first name.")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter a last name.")]
        public string? LastName { get; set; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter an email.")]
        public string? Email { get; set; }

    
        [Required(ErrorMessage = "Please choose a category.")]
        public string? CategoriesId { get; set; }

        [DisplayName("Category")]
        public Categories? Categories { get; set; }

        [DisplayName("Organization")]
        public string? Organization { get; set; }

        [DisplayName("Date Added")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy 'at' h:mm tt}")]
        public DateTime Date { get; set; }
    }
}
