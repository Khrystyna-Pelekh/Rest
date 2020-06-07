using System.Linq;
using UserDto = Lab3.Services.Models.User;
using UserEntity = Lab3.Entities.User;

namespace Lab3.Services.Extensions
{
    public static class UserExtension
    {
        public static UserDto ToDto(this UserEntity entity)
        {
            var dto = new UserDto
            {
                Id = entity.Id,
                UserName = entity.UserName,
                Password = entity.Password,
                Role= (Models.Role)entity.Role,
                Orders = entity.Orders.Select(o => o.ToDto()).ToList()
            };
            return dto;
        }

        public static UserEntity ToEntity(this UserDto dto)
        {
            var entity = new UserEntity
            {
                Id = dto.Id,
                UserName = dto.UserName,
                Password = dto.Password,
                Role = (Entities.Role)dto.Role,
                Orders = dto.Orders.Select(o => o.ToEntity()).ToList()
            };
            return entity;
        }
    }
}
