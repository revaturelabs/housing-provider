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

        public static IDataAccess<Address> GetAddressDAO()
        {
            return new EntityDataAccess<Address>(Context, EntityComparisons.AddressEquals);
        }

        public static IDataAccess<Contact> GetContextDAO()
        {
            return new EntityDataAccess<Contact>(Context, EntityComparisons.ContactEquals);
        }

        public static IDataAccess<Person> GetPersonDAO()
        {
            return new EntityDataAccess<Person>(Context, EntityComparisons.PersonEquals);
        }

        public static IDataAccess<Property> GetPropettyDAO()
        {
            return new EntityDataAccess<Property>(Context, EntityComparisons.PropertyEquals);
        }

        public static IDataAccess<Provider> GetProviderDAO()
        {
            return new EntityDataAccess<Provider>(Context, EntityComparisons.ProviderEquals);
        }

        public static IDataAccess<Request> GetRequestDAO()
        {
            return new EntityDataAccess<Request>(Context, EntityComparisons.RequestEquals);
        }

        public static IDataAccess<Complex> GetComplexDAO()
        {
            return new EntityDataAccess<Complex>(Context, EntityComparisons.ComplexEquals);
        }
    }
}
