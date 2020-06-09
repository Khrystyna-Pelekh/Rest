using System.Collections.Generic;

namespace Lab3.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double Price { get; set; }
    }
}
