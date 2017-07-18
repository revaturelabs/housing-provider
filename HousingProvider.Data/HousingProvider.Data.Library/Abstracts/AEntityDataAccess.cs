using HousingProvider.Data.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Abstracts
{
    public abstract class AEntityDataAccess<T> : IDataAccess<T> where T: class
    {
        public T Create(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T model)
        {
            throw new NotImplementedException();
        }

        public List<T> Read()
        {
            throw new NotImplementedException();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
