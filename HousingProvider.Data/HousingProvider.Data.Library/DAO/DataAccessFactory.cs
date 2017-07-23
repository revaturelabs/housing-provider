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
        public static IDataAccess<T> GetDataAccessObject<T>(DbContext context) where T: class
        {
            return new EntityDataAccess<T>(context);
        }
    }
}
