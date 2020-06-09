using Lab3.Services.Models;
using System.Collections.Generic;

namespace Lab3.Services
{
    public interface IService<TDto>
        where TDto : class, new()
    {
        IEnumerable<TDto> Get();

        TDto Get(int id);

        TDto Create(TDto defect);

        void Update(int id, PatchModel defect);

        void Delete(int id);

        TDto Copy(int id, TDto task);
    }
}
