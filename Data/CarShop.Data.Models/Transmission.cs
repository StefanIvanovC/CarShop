namespace CarShop.Data.Models
{
    using System.Collections.Generic;

    using CarShop.Data.Common.Models;

    public class Transmission : BaseDeletableModel<int>
    {
        public Transmission()
        {
            this.Cars = new HashSet<Car>();
        }

        public string Type { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
