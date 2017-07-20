using HousingProvider.Data.Library.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingProvider.Data.Library.Abstracts
{
    public abstract class AEntityDataAccess<T> : IDataAccess<T> where T: class
    {
        protected DbContext _Context;

        public AEntityDataAccess(DbContext context)
        {
            _Context = context;
        }

        public T Create(T model)
        {
            var added = _Context.Set<T>().Add(model).Entity;
            _Context.SaveChanges();
            return added;
        }

        public T Delete(T model)
        {
            var m = Get(model);
            if (m != null)
            {
                var deleted = _Context.Set<T>().Remove(m).Entity;
                _Context.SaveChanges();
                return deleted;
            }
            return null;
        }

        public List<T> Read()
        {
            return _Context.Set<T>().ToList();
        }

        public T Read(Func<T, bool> comparer)
        {
            return _Context.Set<T>().FirstOrDefault<T>(comparer);
        }

        public T Update(T model)
        {
            if (Delete(model) != null)
            {
                var updated = Create(model);
                _Context.SaveChanges();
                return updated;
            }
            return null;
        }

        public abstract T Get(T model);
    }
}
