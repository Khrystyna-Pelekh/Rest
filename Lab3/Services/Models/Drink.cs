using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Services.Models
{
    public class Drink
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("drinkIngredients")]
        public List<DrinkIngredient> DrinkIngredients { get; set; }
    }
}
