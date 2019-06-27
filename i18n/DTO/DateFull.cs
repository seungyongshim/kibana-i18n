using Newtonsoft.Json;

namespace i18n.DTO
{
    public class DateFull
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string weekday;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string month;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string day;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string year;
    }
}