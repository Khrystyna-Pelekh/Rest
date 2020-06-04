using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Entities
{
    public class PortionOfIngredient
    {
        public int Id { get; set; }
        public Ingredient Ingredient { get; set; }
        public int CountOfUnit { get; set; }
        public double Price { get; set; }
        public Drink Drink { get; set; }
    }
}
