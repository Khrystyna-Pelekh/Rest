using IngredientDto = Lab3.Services.Models.Ingredient;
using IngredientEntity = Lab3.Entities.Ingredient;


namespace Lab3.Services.Extensions
{
    public static class IngredientExtension
    {
        public static IngredientDto ToDto(this IngredientEntity entity)
        {
            var dto = new IngredientDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
            return dto;
        }

        public static IngredientEntity ToEntity(this IngredientDto dto)
        {
            var entity = new IngredientEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price
            };
            return entity;
        }
    }
}
