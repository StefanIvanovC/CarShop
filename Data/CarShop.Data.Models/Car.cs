namespace CarShop.Data.Models
{
    using System.Collections.Generic;

    using CarShop.Data.Common.Models;

    public class Car : BaseDeletableModel<int>
    {
        public Car()
        {
            this.Images = new HashSet<Image>();
            this.Comments = new HashSet<Comment>();
            this.CarExtras = new HashSet<CarExtra>();
        }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public int Year { get; set; }

        public int Milage { get; set; }

        public bool IsUsed { get; set; }

        public string CreatedByUserId { get; set; }

        public virtual ApplicationUser CreatedbyUser { get; set; }

        public int MarkId { get; set; }

        public virtual Mark Mark { get; set; }

        public int EngineId { get; set; }

        public virtual Engine Engine { get; set; }

        public int TransmissionId { get; set; }

        public virtual Transmission Transmission { get; set; }

        public int RegionId { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public string Color { get; set; }

        public virtual ICollection<CarExtra> CarExtras { get; set; }

        public string Features { get; set; }
    }
}
