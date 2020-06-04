using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Drink> OrderItems { get; set; }
        public double Price { get; set; }
    }
}
