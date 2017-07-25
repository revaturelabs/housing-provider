using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Interfaces
{
    public interface IDataAccess<T> where T: class
    {
        T Create(T model);
        List<T> Read(string[] includes);
        T Find(Guid guid, string[] includes);
        bool Update(Guid guid, T model);
        bool Delete(Guid guid);
    }
}
