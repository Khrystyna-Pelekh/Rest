using System.Linq;
using DrinkDto = Lab3.Services.Models.Drink;
using DrinkEntity = Lab3.Entities.Drink;

namespace Lab3.Services.Extensions
{
    public static class DrinkExtension
    {
        public static DrinkDto ToDto(this DrinkEntity entity)
        {
            var dto = new DrinkDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                DrinkIngredients = entity.DrinkIngredients.Select(di=>di.ToDto()).ToList()
            };
            return dto;
        }

        public static DrinkEntity ToEntity(this DrinkDto dto)
        {
            var entity = new DrinkEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                DrinkIngredients = dto.DrinkIngredients.Select(di => di.ToEntity()).ToList()
            };
            return entity;
        }
    }
}
