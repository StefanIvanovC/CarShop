namespace CarShop.Data.Models
{
    using System;

    using CarShop.Data.Common.Models;

    public class Marketing : BaseDeletableModel<string>
    {
        public Marketing()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CreatedByUserId { get; set; }

        public virtual ApplicationUser CreatedbyUser { get; set; }
    }
}
