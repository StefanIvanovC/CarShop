namespace CarShop.Web.ViewModels.Cars
{
    using System;

    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class CarCommentViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }

        public int? ParentId { get; set; }
    }
}
