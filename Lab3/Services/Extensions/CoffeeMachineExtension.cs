using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeMachineDto = Lab3.Services.Models.CoffeeMachine;
using CoffeeMachineEntity = Lab3.Entities.CoffeeMachine;

namespace Lab3.Services.Extensions
{
    public static class CoffeeMachineExtension
    {
        public static CoffeeMachineDto ToDto(this CoffeeMachineEntity entity)
        {
            var dto = new CoffeeMachineDto
            {
                Id = entity.Id,
                Brand = entity.Brand,
                Configs = entity.Configs.Select(c => c.ToDto()).ToList()
            };
            return dto;
        }

        public static CoffeeMachineEntity ToEntity(this CoffeeMachineDto dto)
        {
            var entity = new CoffeeMachineEntity
            {
                Id = dto.Id,
                Brand = dto.Brand,
               Configs = dto.Configs.Select(c => c.ToEntity()).ToList()
            };
            return entity;
        }
    }
}
