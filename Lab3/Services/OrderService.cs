using Lab3.DataAccess;
using Lab3.Entities;
using Lab3.Services.Extensions;
using Lab3.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderDto = Lab3.Services.Models.Order;
using OrderEntity = Lab3.Entities.Order;
using MachineConfigEntity = Lab3.Entities.MachineConfig;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Internal;

namespace Lab3.Services
{
    public class OrderService : ServiceBase<OrderDto, OrderEntity>, IService<OrderDto>
    {
        public OrderService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public IEnumerable<OrderDto> Get()
        {
            throw new NotImplementedException();
        }

        public OrderDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDto Create(OrderDto orderDto)
        {
            var entity = orderDto.ToEntity();
            var machineConfig = UnitOfWork.GetRepository<MachineConfigEntity>().Get();

            var totalPrice = 0d;
            var count = 0;
            foreach (var item in entity.OrderItems)
            {
                totalPrice += item.Drink.Price;
                foreach (var ingredient in item.AdditionalIngredients)
                {
                    totalPrice += ingredient.Ingredient.Price * ingredient.Count;
                }
            }
            foreach(var countOf in entity.OrderItems)
            {
                foreach(var unit in countOf.Drink.DrinkIngredients)
                {
                   
                }
            }
            Repository.Add(entity);
            UnitOfWork.SaveChanges();
            return Get(orderDto.Id);
        }

        public void Update(int id, OrderDto orderDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDto Copy(int id, OrderDto orderDto)
        {
            throw new NotImplementedException();
        }
    }
}
