using AdditionalIngredientDto = Lab3.Services.Models.AdditionalIngredient;
using AdditionalIngredientEntity = Lab3.Entities.AdditionalIngredient;

namespace Lab3.Services.Extensions
{
    public static class AdditionalIngredientExtension
    {
        public static AdditionalIngredientDto ToDto(this AdditionalIngredientEntity entity)
        {
            var dto = new AdditionalIngredientDto
            {
                Id = entity.Id,
                Ingredient = entity.Ingredient.ToDto(),
                Count=entity.Count
            };
            return dto;
        }

        public static AdditionalIngredientEntity ToEntity(this AdditionalIngredientDto dto)
        {
            var entity = new AdditionalIngredientEntity
            {
                Id = dto.Id,
                Ingredient = dto.Ingredient.ToEntity(),
                Count = dto.Count
            };
            return entity;
        }
    }
}
