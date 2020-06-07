using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Services.Models
{
    public class AdditionalIngredient
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ingredients")]
        public Ingredient Ingredient { get; set; }
        [Required]
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
