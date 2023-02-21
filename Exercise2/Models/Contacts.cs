using System.ComponentModel;

namespace Exercise2.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [DisplayName("Phone")]
        public string? PhoneNumber { get; set; }
        [DisplayName("Email")]
        public string? Email { get; set; }
        [DisplayName("Category")]
        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }
        [DisplayName("Organization")]
        public string? Organization { get; set; }
        [DisplayName("Date Added")]
        public DateTime Date { get; set; }
    }
}
