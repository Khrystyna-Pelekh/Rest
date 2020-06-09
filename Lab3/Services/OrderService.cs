using Lab3.DataAccess;
using Lab3.Services.Extensions;
using Lab3.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using OrderDto = Lab3.Services.Models.Order;
using OrderEntity = Lab3.Entities.Order;

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
            return Repository.Get()
                .Include("User")
                .Include("OrderItems")
                .Include("OrderItems.Drink")
                .Include("OrderItems.Drink.DrinkIngredients")
                .Include("OrderItems.Drink.DrinkIngredients.Ingredient")
                .Include("OrderItems.AdditionalIngredients")
                .Include("OrderItems.AdditionalIngredients.Ingredient").Select(u => u.ToDto());
        }

        public OrderDto Get(int id)
        {
            return Repository.Get(o=>o.Id==id)
                .Include("User")
                .Include("OrderItems")
                .Include("OrderItems.Drink")
                .Include("OrderItems.Drink.DrinkIngredients")
                .Include("OrderItems.Drink.DrinkIngredients.Ingredient")
                .Include("OrderItems.AdditionalIngredients")
                .Include("OrderItems.AdditionalIngredients.Ingredient").SingleOrDefault().ToDto();
        }

        public OrderDto Create(OrderDto orderDto)
        {
            var entity = orderDto.ToEntity();
            var machineConfig = UnitOfWork.GetRepository<Entities.MachineConfig>().Get();
            var users = UnitOfWork.GetRepository<Entities.User>().Get(u=>u.Id==entity.User.Id).SingleOrDefault();
            var drinkRepo = UnitOfWork.GetRepository<Entities.Drink>();
            var findIngredients = UnitOfWork.GetRepository<Entities.Ingredient>();
            entity.User = users;
            var totalPrice = 0d;
            foreach (var item in entity.OrderItems)
            {
                item.Drink = drinkRepo.Get(d => d.Id == item.Drink.Id)
                    .Include("DrinkIngredients")
                    .Include("DrinkIngredients.Ingredient").SingleOrDefault();
                totalPrice += item.Drink.Price;
                foreach (var ingredient in item.AdditionalIngredients)
                {
                    ingredient.Ingredient = findIngredients.Get(i => i.Id == ingredient.Ingredient.Id).SingleOrDefault();
                    totalPrice += ingredient.Ingredient.Price * ingredient.Count;
                }
            }
            entity.Price = totalPrice;

            var ingredients = new Dictionary<int, int>();
            foreach (var orderItem in entity.OrderItems)
            {
                foreach (var unit in orderItem.Drink.DrinkIngredients)
                {
                    if (!ingredients.ContainsKey(unit.Ingredient.Id))
                    {
                        ingredients.Add(unit.Ingredient.Id, 0);
                    }
                    ingredients[unit.Ingredient.Id] += unit.CountOfUnit;
                }

                foreach (var unit in orderItem.AdditionalIngredients)
                {
                    ingredients[unit.Ingredient.Id] += unit.Count;
                }
            }

            var isEnough = true;
            foreach (var ingredient in ingredients)
            {
                var config = machineConfig.Single(mc => mc.Ingredient.Id == ingredient.Key);
                if (config.CurrentCapacity < ingredient.Value)
                {
                    // Not enough capacity in coffee machine
                    isEnough = false;
                    break;
                }

                config.CurrentCapacity -= ingredient.Value;
            }

            if (isEnough)
            {
                Repository.Add(entity);
                UnitOfWork.SaveChanges();

                return entity.ToDto();
            }

            return null;
        }

        public void Update(int id, PatchModel orderDto)
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
