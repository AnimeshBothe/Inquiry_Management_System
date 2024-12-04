using System.ComponentModel.DataAnnotations;

namespace InquiryApp.Models
{
    public class Inquiry
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Hobbies { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string Pincode { get; set; }
    }
}
