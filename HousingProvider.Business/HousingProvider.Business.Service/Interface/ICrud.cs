using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.Interface
{
    public interface ICrud<T> where T : new()
    {
        List<T> Get();
        bool Create(T obj);
        bool Delete(T obj);
        bool Update(T obj);

    }
}
