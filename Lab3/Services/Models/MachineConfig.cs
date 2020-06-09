using Newtonsoft.Json;

namespace Lab3.Services.Models
{
    public class MachineConfig
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ingredients")]
        public Ingredient Ingredient { get; set; }
        [JsonProperty("maxCapacity")]
        public int MaxCapacity { get; set; }
        [JsonProperty("currentCapacity")]
        public int CurrentCapacity { get; set; }
    }
}
