using Newtonsoft.Json;

namespace i18n.DTO
{
    public class Time
    {
        [JsonProperty("short")]
        public TimeFull @short;

        [JsonProperty("medium")]
        public TimeFull @medium;

        [JsonProperty("long")]
        public TimeFull @long;

        [JsonProperty("full")]
        public TimeFull full;
    }
}