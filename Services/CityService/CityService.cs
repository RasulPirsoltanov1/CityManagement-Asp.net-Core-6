using AutoMapper;
using WebApplication2.Core;
using WebApplication2.Core.Dtos;
using WebApplication2.Core.Dtos.City;

namespace WebApplication2.Services.CityService
{
    public class CityService : ICityService
    {
        private readonly static List<CityEntity> _cityEntity = new List<CityEntity>()
        {
            new CityEntity(),
            new CityEntity()
            {
                Name="Ismayilli",
                Id=2,
                Population=124,
            },
            new CityEntity()
            {
                Name="Ismayilli",
                Id=3,
                Population=124,
            }
        };
        private IMapper _mapper;

        public CityService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ServiceResponse<List<GetCityDto>> AddCity(AddCityDto cityEntity)
        {
            var response = new ServiceResponse<List<GetCityDto>>();
            response.Success = true;
            CityEntity entity = new();
            entity.Id = _cityEntity.Max(x => x.Id) + 1;
            var city = _mapper.Map<CityEntity>(cityEntity);
            city.Id = entity.Id;
            _cityEntity.Add(city);
            var getCity = _mapper.Map<List<GetCityDto>>(_cityEntity);
            response.Data = getCity;
            return response;
        }

        public ServiceResponse<List<GetCityDto>> DeleteCity(int id)
        {
            var response = new ServiceResponse<List<GetCityDto>>();
            var city=_cityEntity.Find(i => i.Id == id);
            _cityEntity.Remove(city);
            response.Success = true;
            response.Data = _mapper.Map<List<GetCityDto>>(_cityEntity);
            return response;
        }

        public ServiceResponse<List<GetCityDto>> GetAll()
        {
            var response = new ServiceResponse<List<GetCityDto>>();
            response.Success = true;
            response.Data = _mapper.Map<List<GetCityDto>>(_cityEntity);
            return response;
        }

        public ServiceResponse<GetCityDto> GetById(int id)
        {
            var response = new ServiceResponse<GetCityDto>();
            response.Success = true;
            response.Data = _mapper.Map<GetCityDto>(_cityEntity.Find(i => i.Id == id));
            return response;
        }

        public ServiceResponse<GetCityDto> UpdateCity(UpdateCityDto updateCityDto)
        {
            var response = new ServiceResponse<GetCityDto>();
            try
            {
                CityEntity? cityEntity = _cityEntity.Find(i => i.Id == updateCityDto.Id);
                cityEntity.Name = updateCityDto.Name;
                cityEntity.Population = updateCityDto.Population;
                cityEntity.Class = updateCityDto.Class;
                response.Data = _mapper.Map<GetCityDto>(cityEntity);
                response.Success = true;
                response.Message = "Updated Succesfully";
                return response;

            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Success = true;
                response.Message = "Something went wrong!";
                return response;
            }
        }
    }
}
