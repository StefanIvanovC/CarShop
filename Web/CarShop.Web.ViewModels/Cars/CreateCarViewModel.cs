namespace CarShop.Web.ViewModels.Cars
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class CreateCarViewModel
    {
        [Required]
        [Range(0, 1_000_000)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(50)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1900, 2023)]
        public int Year { get; set; }

        [Required]
        [Range(0, 1_000_000)]
        public int Milage { get; set; }

        [Required]
        public bool IsUsed { get; set; }

        [Required]
        public int MarkId { get; set; }

        [Required]
        public int EngineId { get; set; }

        [Required]
        public int TransmissionId { get; set; }

        [Required]
        public int RegionId { get; set; }

        [Required]
        public IEnumerable<IFormFile> Images { get; set; }

        [Required]
        [RegularExpression(@"08[789]\d{7}", ErrorMessage = "Characters are not allowed.")]
        public string TelephoneNumber { get; set; }

        [Required]
        public string Color { get; set; }

        public IEnumerable<CarExtrasInputModel> Extras { get; set; }
    }
}
