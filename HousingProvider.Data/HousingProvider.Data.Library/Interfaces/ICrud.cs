using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Interfaces
{
    public interface ICrud<T>
    {
        T Get(T obj);
        List<T> GetAll();
        bool Add(T ObjectToBeAdded);
        bool Delete(T ObjectToBeDeleted);
        bool Update(T ObjectToBeUpdated);
    }
}
