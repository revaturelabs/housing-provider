using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Interfaces
{
    public interface IDataAccess<T> where T: class
    {
        T Create(T model);
        List<T> Read();
        T Find(Guid guid);
        bool Update(Guid guid, T model);
        bool Delete(Guid guid);
    }
}
