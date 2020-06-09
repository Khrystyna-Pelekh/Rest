using Newtonsoft.Json;

namespace Lab3.Services.Models
{
    public class DrinkIngredient
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ingredient")]
        public Ingredient Ingredient { get; set; }
        [JsonProperty("countOfUnit")]
        public int CountOfUnit { get; set; }
    }
}
