using System.Collections.Generic;

namespace Lab3.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<DrinkIngredient> DrinkIngredients { get; set; }
    }
}
