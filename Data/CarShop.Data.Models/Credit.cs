namespace CarShop.Data.Models
{
    using CarShop.Data.Common.Models;

    public class Credit : BaseDeletableModel<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsWorking { get; set; }

        public bool IsApproved { get; set; }

        public ushort TotalMoney { get; set; }

        public byte MonthPeriod { get; set; }

        public string CreatedByUserId { get; set; }

        public virtual ApplicationUser CreatedbyUser { get; set; }
    }
}
