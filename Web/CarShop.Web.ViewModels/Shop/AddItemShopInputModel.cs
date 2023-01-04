namespace CarShop.Web.ViewModels.Shop
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class AddItemShopInputModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(20)]
        public string Description { get; set; }

        [Required]
        [Range(0, 10)]
        public int Price { get; set; }

        [Required]
        public IFormFile Image { get; set; }
    }
}
