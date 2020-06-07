using System.Linq;
using MachineConfigDto = Lab3.Services.Models.MachineConfig;
using MachineConfigEntity = Lab3.Entities.MachineConfig;

namespace Lab3.Services.Extensions
{
    public static class MachineConfigExtension
    {
        public static MachineConfigDto ToDto(this MachineConfigEntity entity)
        {
            var dto = new MachineConfigDto
            {
                Id = entity.Id,
                Ingredient = entity.Ingredient.ToDto(),
                CurrentCapacity = entity.CurrentCapacity,
                MaxCapacity = entity.MaxCapacity
            };
            return dto;
        }

        public static MachineConfigEntity ToEntity(this MachineConfigDto dto)
        {
            var entity = new MachineConfigEntity
            {
                Id = dto.Id,
                Ingredient = dto.Ingredient.ToEntity(),
                CurrentCapacity = dto.CurrentCapacity,
                MaxCapacity = dto.MaxCapacity
            };
            return entity;
        }
    }
}
