using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Interfaces
{
    public interface ICrud<T> where T: new()
    {
        List<T> Get();
        bool Create(T obj);
        bool Update(T obj);
        bool Delete(T obj);
    }
}
