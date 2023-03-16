namespace WebApplication2.Core.Dtos.City
{
    public class AddCityDto
    {
        public string Name { get; set; } = "Baki";
        public int Population { get; set; } = 17000;
        public RgbCity Class { get; set; } = RgbCity.Qarabag;
    }
}
