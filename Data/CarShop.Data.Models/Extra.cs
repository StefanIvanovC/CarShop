namespace CarShop.Data.Models
{
    using System.Collections.Generic;

    using CarShop.Data.Common.Models;

    public class Extra : BaseModel<int>
    {
        public Extra()
        {
            this.Extras = new HashSet<CarExtra>();
        }

        public string Name { get; set; }

        public virtual ICollection<CarExtra> Extras { get; set; }
    }
}
