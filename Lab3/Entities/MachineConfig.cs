namespace Lab3.Entities
{
    public class MachineConfig
    {
        public int Id { get; set; }
        public Ingredient Ingredient { get; set; }
        public int MaxCapacity { get; set; }
        public int CurrentCapacity { get; set; }
    }
}
