using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Services.Models
{
    public class OrderItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("drink")]
        public Drink Drink { get; set; }
        [JsonProperty("additionalIngredients")]
        public List<AdditionalIngredient> AdditionalIngredients { get; set; }
    }
}
