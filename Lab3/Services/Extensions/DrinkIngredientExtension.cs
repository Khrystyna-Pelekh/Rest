using DrinkIngredientDto = Lab3.Services.Models.DrinkIngredient;
using DrinkIngredientEntity = Lab3.Entities.DrinkIngredient;
namespace Lab3.Services.Extensions
{
    public static class DrinkIngredientExtension
    {
        public static DrinkIngredientDto ToDto(this DrinkIngredientEntity entity)
        {
            var dto = new DrinkIngredientDto
            {
                Id = entity.Id,
                Ingredient = entity.Ingredient.ToDto(),
                CountOfUnit = entity.CountOfUnit
            };
            return dto;
        }

        public static DrinkIngredientEntity ToEntity(this DrinkIngredientDto dto)
        {
            var entity = new DrinkIngredientEntity
            {
                Id = dto.Id,
                Ingredient = dto.Ingredient.ToEntity(),
                CountOfUnit = dto.CountOfUnit
            };
            return entity;
        }
    }
}

