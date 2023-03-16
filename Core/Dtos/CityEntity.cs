namespace WebApplication2.Core.Dtos
{
    public class CityEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; } = "Baki";
        public int Population { get; set; } = 17000;
        public RgbCity Class { get; set; } = RgbCity.Qarabag;
    }
}
