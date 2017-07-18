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

        public T Update(T model)
        {
            var m = Get(model);
            if (m != null)
            {
                if (Delete(m) != null)
                {
                    var updated = Create(m);
                    _Context.SaveChanges();
                    return updated;
                }
            }
            return null;
        }

        public abstract T Get(T model);
    }
}
