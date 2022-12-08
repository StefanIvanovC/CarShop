namespace CarShop.Web.ViewModels.Cars
{
    using System;
    using System.Collections.Generic;

    public class CarListViewModel
    {
        public IEnumerable<CarInListViewModel> Cars { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PageCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PageCount => (int)Math.Ceiling((double)this.CarCount / this.ItemsPerPage);

        public int PageNumber { get; set; }

        public int CarCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
