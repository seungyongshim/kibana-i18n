using Newtonsoft.Json;

namespace i18n.DTO
{
    public class TimeFull
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string hour;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string minute;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string second;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string timeZoneName;
    }
}