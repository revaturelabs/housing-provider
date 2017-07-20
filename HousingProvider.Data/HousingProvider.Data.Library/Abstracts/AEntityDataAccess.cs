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
        public delegate bool EntityEquals(T model1, T model2);

        protected DbContext _Context;

        private EntityEquals Eq;

        public AEntityDataAccess(DbContext context, EntityEquals eq)
        {
            _Context = context;
            Eq = eq;
        }

        public T Create(T model)
        {
            var added = _Context.Set<T>().Add(model).Entity;
            _Context.SaveChanges();
            return added;
        }

        public T Delete(T model)
        {
            var m = Find(model);
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

        public T Find(T model)
        {
            return _Context.Set<T>().FirstOrDefault(m => Eq(m, model));
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
