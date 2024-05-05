using System.Text.Json.Serialization;

namespace Domain.Entities
{
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ClassLocation
    {
        HCM,
        HN,
        DN
    }
}