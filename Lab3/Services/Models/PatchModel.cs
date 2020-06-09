using Newtonsoft.Json;

namespace Lab3.Services.Models
{
    public class PatchModel
    {
        [JsonProperty("op")]
        public string Operation { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
