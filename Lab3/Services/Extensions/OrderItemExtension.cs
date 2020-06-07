using System.Linq;
using OrderItemDto = Lab3.Services.Models.OrderItem;
using OrderItemEntity = Lab3.Entities.OrderItem;

namespace Lab3.Services.Extensions
{
    public static class OrderItemExtension
    {
        public static OrderItemDto ToDto(this OrderItemEntity entity)
        {
            var dto = new OrderItemDto
            {
                Id = entity.Id,
                Drink = entity.Drink.ToDto(),
                AdditionalIngredients = entity.AdditionalIngredients.Select(ai => ai.ToDto()).ToList()            };
            return dto;
        }

        public static OrderItemEntity ToEntity(this OrderItemDto dto)
        {
            var entity = new OrderItemEntity
            {
                Id = dto.Id,
                Drink = dto.Drink.ToEntity(),
                AdditionalIngredients = dto.AdditionalIngredients.Select(ai => ai.ToEntity()).ToList()
            };
            return entity;
        }
    }
}

