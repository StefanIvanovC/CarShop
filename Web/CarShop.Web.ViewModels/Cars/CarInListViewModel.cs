namespace CarShop.Web.ViewModels.Cars
{
    using System.Linq;

    using AutoMapper;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class CarInListViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public int EngineId { get; set; }

        public string ImageUrl { get; set; }

        public string MarkName { get; set; }

        public decimal Price { get; set; }

        public int Milage { get; set; }

        public string RegionName { get; set; }

        public string Description { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Car, CarInListViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                        x.Images.FirstOrDefault().RemoteImageUrl :
                        "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
