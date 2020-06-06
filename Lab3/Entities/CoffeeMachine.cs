using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Entities
{
    public class CoffeeMachine
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public List<MachineConfig> Configs { get; set; }
    }
}
