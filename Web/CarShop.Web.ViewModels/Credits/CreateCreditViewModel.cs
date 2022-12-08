namespace CarShop.Web.ViewModels.Credits
{
    using System.ComponentModel.DataAnnotations;

    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class CreateCreditViewModel : IMapFrom<Credit>
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public bool IsWorking { get; set; }

        public bool IsApproved { get; set; }

        [Required]
        [Range(1000, 50000)]
        public ushort TotalMoney { get; set; }

        [Required]
        [Range(6, 36)]
        public byte MonthPeriod { get; set; }
    }
}
