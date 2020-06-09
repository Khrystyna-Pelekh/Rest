using Newtonsoft.Json;

namespace Lab3.Services.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}
