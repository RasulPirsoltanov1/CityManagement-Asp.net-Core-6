using WebApplication2.Core;
using WebApplication2.Core.Dtos;
using WebApplication2.Core.Dtos.City;

namespace WebApplication2.Services.CityService
{
    public interface ICityService
    {
        ServiceResponse<List<GetCityDto>> GetAll();
        ServiceResponse<GetCityDto> GetById(int id);
        ServiceResponse<List<GetCityDto>> AddCity(AddCityDto addCityDto);
        ServiceResponse<GetCityDto> UpdateCity(UpdateCityDto updateCityDto);
        ServiceResponse<List<GetCityDto>> DeleteCity(int id);
    }
}
