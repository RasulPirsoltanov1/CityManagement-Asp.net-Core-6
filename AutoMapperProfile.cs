using AutoMapper;
using WebApplication2.Core.Dtos;
using WebApplication2.Core.Dtos.City;

namespace WebApplication2
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CityEntity, GetCityDto>().ReverseMap();
            CreateMap<CityEntity, AddCityDto>().ReverseMap();
            CreateMap<UpdateCityDto, GetCityDto>().ReverseMap();
        }
    }
}
