﻿using Lab3.DataAccess;
using System.Collections.Generic;
using System.Linq;
using DrinkDto = Lab3.Services.Models.Drink;
using DrinkEntity = Lab3.Entities.Drink;
using Lab3.Services.Extensions;
using Microsoft.EntityFrameworkCore;
using Lab3.Services.Models;

namespace Lab3.Services
{
    public class DrinkService : ServiceBase<DrinkDto, DrinkEntity>, IService<DrinkDto>
    {
        public DrinkService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public IEnumerable<DrinkDto> Get()
        {
            return Repository.Get()
                .Include("DrinkIngredients")
                .Include("DrinkIngredients.Ingredient").Select(u => u.ToDto());
        }

        public DrinkDto Get(int id)
        {
            return Repository.Get(u => u.Id == id)
                .Include("DrinkIngredients")
                .Include("DrinkIngredients.Ingredient").SingleOrDefault()?.ToDto();
        }

        public DrinkDto Create(DrinkDto drinkDto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, PatchModel drink)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public DrinkDto Copy(int id, DrinkDto drink)
        {
            throw new System.NotImplementedException();
        }
    }
}
