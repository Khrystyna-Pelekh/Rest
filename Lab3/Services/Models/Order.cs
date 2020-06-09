using Newtonsoft.Json;
using System.Collections.Generic;

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
