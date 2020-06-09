using System.Collections.Generic;

namespace Lab3.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Drink Drink { get; set; }
        public List<AdditionalIngredient> AdditionalIngredients { get; set; }
    }
}
