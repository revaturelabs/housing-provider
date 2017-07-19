using HousingProvider.Data.Library.EFModels;
using HousingProvider.Data.Library.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Abstracts
{
    public abstract class ADataAccessFactory
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

        public static IDataAccess<T> GetDAO<T>()
        {
            
        }
    }
}
