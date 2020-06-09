using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab3.Services.Models
{
    public class CoffeeMachine
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("brand")]
        public string Brand { get; set; }
        [JsonProperty("configs")]
        public List<MachineConfig> Configs { get; set; }
    }
}
