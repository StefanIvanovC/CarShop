namespace CarShop.Web.ViewModels.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class ByIdCarViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public int Year { get; set; }

        public int Milage { get; set; }

        public bool IsUsed { get; set; }

        public string CreatedByUserUserName { get; set; }

        public string MarkName { get; set; }

        public string EngineType { get; set; }

        public string TransmissionType { get; set; }

        public string RegionName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ImageUrl { get; set; }

        public ushort CommentsCounter => 1;

        public IEnumerable<CarCommentViewModel> Comments { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Car, ByIdCarViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                        x.Images.FirstOrDefault().RemoteImageUrl :
                        "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }

        public string Color { get; set; }
    }
}
