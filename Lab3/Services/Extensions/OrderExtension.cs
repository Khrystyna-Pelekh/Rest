using System.Linq;
using OrderDto = Lab3.Services.Models.Order;
using OrderEntity = Lab3.Entities.Order;

namespace Lab3.Services.Extensions
{
    public static class OrderExtension
    {
        public static OrderDto ToDto(this OrderEntity entity)
        {
            var dto = new OrderDto
            {
                Id = entity.Id,
                //User = entity.User.ToDto(),
                Price = entity.Price,
                OrderItems = entity.OrderItems.Select(oi => oi.ToDto()).ToList()
            };
            return dto;
        }

        public static OrderEntity ToEntity(this OrderDto dto)
        {
            var entity = new OrderEntity
            {
                Id = dto.Id,
                //User = entity.User.ToEntity(),
                Price = dto.Price,
                OrderItems = dto.OrderItems.Select(oi => oi.ToEntity()).ToList()
            };
            return entity;
        }
    }
}
