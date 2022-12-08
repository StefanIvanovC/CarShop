namespace CarShop.Web.ViewModels.Marketing
{
    using System.ComponentModel.DataAnnotations;

    public class CreateEmailMarketingViewModel
    {
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MinLength(20)]
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
