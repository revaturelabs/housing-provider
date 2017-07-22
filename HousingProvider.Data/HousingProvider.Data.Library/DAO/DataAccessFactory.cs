using HousingProvider.Data.Library.Models;
using HousingProvider.Data.Library.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.DAO
{
    public static class DataAccessFactory
    {
        private static DbContext _Context;

        public static DbContext Context
        {
            get
            {
                if (_Context == null)
                {
                    _Context = new HousingProviderDBContext();
                }
                return _Context;
            }
        }

        public static IDataAccess<T> GetDataAccessObject<T>() where T: class
        {
            return new EntityDataAccess<T>(Context);
        }
    }
}
