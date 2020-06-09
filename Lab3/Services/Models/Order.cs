using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Services.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("orderItems")]
        public List<OrderItem> OrderItems { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
    }
}
