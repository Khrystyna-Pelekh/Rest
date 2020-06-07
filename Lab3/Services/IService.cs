using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Services
{
    public interface IService<TDto>
        where TDto : class, new()
    {
        IEnumerable<TDto> Get();

        TDto Get(int id);

        TDto Create(TDto defect);

        void Update(int id, TDto defect);

        void Delete(int id);

        TDto Copy(int id, TDto task);
    }
}
