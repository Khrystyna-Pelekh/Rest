using Lab3.DataAccess;
using Lab3.Services.Extensions;
using Lab3.Services.Models;
using System.Collections.Generic;
using System.Linq;
using IngredientDto = Lab3.Services.Models.Ingredient;
using IngredientEntity = Lab3.Entities.Ingredient;

namespace Lab3.Services
{
    public class IngredientService : ServiceBase<IngredientDto, IngredientEntity>, IService<IngredientDto>
    {
        public IngredientService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public IEnumerable<IngredientDto> Get()
        {
            return Repository.Get().Select(u => u.ToDto());
        }

        public IngredientDto Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IngredientDto Create(IngredientDto ingredientDto)
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

        public IngredientDto Copy(int id, IngredientDto ingredient)
        {
            throw new System.NotImplementedException();
        }
    }
}

