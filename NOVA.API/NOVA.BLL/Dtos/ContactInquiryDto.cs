

using System.ComponentModel.DataAnnotations;

namespace NOVA.BLL.Dtos
{
    public class ContactInquiryDto
    {

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Subject is required.")]
        [MaxLength(200)]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Message is required.")]
        [MaxLength(1000)]
        public string Message { get; set; }
    }
}
