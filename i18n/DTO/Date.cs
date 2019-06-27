using Newtonsoft.Json;

namespace i18n.DTO
{

    public class Date
    {
        [JsonProperty("short")]
        public DateFull @short;

        [JsonProperty("medium")]
        public DateFull @medium;

        [JsonProperty("long")]
        public DateFull @long;

        public DateFull full;
    }
}
