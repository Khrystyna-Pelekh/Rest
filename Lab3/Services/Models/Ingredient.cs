using Newtonsoft.Json;

namespace Lab3.Services.Models
{
    public class Ingredient
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
    }
}
