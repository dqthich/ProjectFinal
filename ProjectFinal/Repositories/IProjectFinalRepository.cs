using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Repositories
{
    interface IProjectFinalRepository <T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetbyId(int id);
        Task<T> Create(T t);
        Task Update(T t);
        Task Delete(int id);

    }
}
