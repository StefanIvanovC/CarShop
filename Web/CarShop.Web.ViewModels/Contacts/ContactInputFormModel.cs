namespace CarShop.Web.ViewModels.Contacts
{
    using System.ComponentModel.DataAnnotations;

    public class ContactInputFormModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"08[789]\d{7}", ErrorMessage = "This phone number is fake")]
        public string TelephoneNumber { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Message { get; set; }
    }
}
