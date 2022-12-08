namespace CarShop.Data.Models
{
    using CarShop.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }
    }
}
