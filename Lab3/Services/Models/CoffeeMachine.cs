using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
