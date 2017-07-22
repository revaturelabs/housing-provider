using HousingProvider.Data.Library.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HousingProvider.Data.Library.DAO
{
    public class EntityDataAccess<T> : IDataAccess<T> where T: class
    {
        public delegate bool EntityEquals(T model1, T model2);

        protected DbContext _Context;

        private EntityEquals Eq;

        public EntityDataAccess(DbContext context, EntityEquals eq)
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

        public T Delete(Guid guid)
        {
            var m = Find(guid);
            if (m != null)
            {
                return _Context.Set<T>().Remove(m).Entity;
            }
            return null;
        }

        public List<T> Read()
        {
            return _Context.Set<T>().ToList();
        }

        public T Find(Guid guid)
        {
            var g = typeof(T).GetProperty("Guid");
            if (g != null)
            {
                return _Context.Set<T>().FirstOrDefault(m => ((Guid)g.GetValue(m)) == guid);
            }
            throw new InvalidOperationException("Cannot find a model that lacks a Guid property.");
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
    }
}
