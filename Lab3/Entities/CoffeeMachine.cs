using System.Collections.Generic;

namespace Lab3.Entities
{
    public class CoffeeMachine
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public List<MachineConfig> Configs { get; set; }
    }
}
