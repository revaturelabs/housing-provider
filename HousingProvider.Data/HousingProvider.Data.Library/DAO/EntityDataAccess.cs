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
        protected DbContext _Context;

        public EntityDataAccess(DbContext context)
        {
            _Context = context;
        }

        public T Create(T model)
        {
            var added = _Context.Set<T>().Add(model).Entity;
            _Context.SaveChanges();
            return added;
        }

        public bool Delete(Guid guid)
        {
            var m = Find(guid);
            if (m != null)
            {
                var e = _Context.Set<T>().Remove(m);
                _Context.SaveChanges();
                return e != null;
            }
            return false;
        }

        public List<T> Read(string[] includes = null)
        {
            return _Context.Set<T>().ToList();
        }

        public T Find(Guid guid, string[] includes = null)
        {
            var g = typeof(T).GetProperty("Guid");
            if (g != null)
            {
                return _Context.Set<T>().FirstOrDefault(m => ((Guid)g.GetValue(m)) == guid);
            }
            throw new InvalidOperationException("Cannot find a model that lacks a Guid property.");
        }

        public bool Update(Guid guid, T model)
        {
            if (Delete(guid))
            {
                var e = _Context.Set<T>().Add(model);
                _Context.SaveChanges();
                return e != null;
            }
            return false;
        }
    }
}
