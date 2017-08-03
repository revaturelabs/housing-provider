using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Interfaces
{
    public interface IDataAccess<T> where T: class
    {
        T Create(T model);
        List<T> Read(string[] includes = null, int pageIndex = 0, int pageSize = 0);
        T Find(Guid guid, string[] includes = null);
        bool Update(Guid guid, T model);
        bool Delete(Guid guid);
    }
}
