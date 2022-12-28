namespace CarShop.Data.Models
{
    using CarShop.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public string Message { get; set; }

        public string CreatedByUserId { get; set; }

        public virtual ApplicationUser CreatedbyUser { get; set; }
    }
}
