namespace CarShop.Data.Models
{
    using System.Collections.Generic;

    using CarShop.Data.Common.Models;

    public class Engine : BaseDeletableModel<int>
    {
        public Engine()
        {
            this.Cars = new HashSet<Car>();
        }

        public string Type { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
