using Lab3.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Context
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<CoffeeMachine> CoffeeMachine { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MachineConfig> MachineConfigs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<DrinkIngredient> DrinkIngredients { get; set; }
        public DbSet<AdditionalIngredient> AdditionalIngredients { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

