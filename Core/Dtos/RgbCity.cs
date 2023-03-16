using System.Text.Json.Serialization;

namespace WebApplication2.Core.Dtos
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RgbCity
    {
        Abseron,
        Aran,
        Naxcivan,
        Qarabag
    }
}
