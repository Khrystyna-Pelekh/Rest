using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Drink Drink { get; set; }
        public List<AdditionalIngredient> AdditionalIngredients { get; set; }
        public double Price { get; set; }
    }
}
