namespace CarShop.Web.ViewModels.Credits
{
    using System;

    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class CreditByIdViewModel : IMapFrom<Credit>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsWorking { get; set; }

        public bool IsApproved { get; set; }

        public ushort TotalMoney { get; set; }

        public byte MonthPeriod { get; set; }

        public string CreatedByUserId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
