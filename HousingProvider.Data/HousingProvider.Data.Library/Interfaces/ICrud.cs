using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Interfaces
{
    public interface ICrud<T, U>
        where U : class
    {
        T Get(U obj);
        List<T> GetAll();
        bool Add(T ObjectToBeAdded);
        bool Delete(T ObjectToBeDeleted);
        bool Update(T ObjectToBeUpdated);
    }
}
