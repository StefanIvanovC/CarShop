namespace CarShop.Data.Models
{
    using CarShop.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string CreatedByUserId { get; set; }

        public virtual ApplicationUser CreatedbyUser { get; set; }

       //TODO ADD Image for product other table
    }
}
