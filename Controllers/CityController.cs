using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Core;
using WebApplication2.Core.Dtos;
using WebApplication2.Core.Dtos.City;
using WebApplication2.Services.CityService;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        public ServiceResponse<List<GetCityDto>> Get()
        {
            return _cityService.GetAll();
        }
        [HttpGet("{id}")]
        public ServiceResponse<GetCityDto> GetById(int id)
        {
            return _cityService.GetById(id);
        }
        [HttpPost]
        public ServiceResponse<List<GetCityDto>> AddCity(AddCityDto cityEntity)
        {
            return _cityService.AddCity(cityEntity);
        }
        [HttpPut("Update")]
        public ServiceResponse<GetCityDto> UpdateCity(UpdateCityDto updateCityDto)
        {
            return _cityService.UpdateCity(updateCityDto);
        }
        [HttpDelete("Delete/{id}")]
        public ServiceResponse<List<GetCityDto>> DeleteCity(int id)
        {
            return _cityService.DeleteCity(id);
        }
    }
}
