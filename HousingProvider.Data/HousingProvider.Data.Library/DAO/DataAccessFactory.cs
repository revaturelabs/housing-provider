using HousingProvider.Data.Library.DAO;
using HousingProvider.Data.Library.EFModels;
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
            return new AddressDAO(Context);
        }

        public static IDataAccess<Contact> GetContextDAO()
        {
            return new ContactDAO(Context);
        }

        public static IDataAccess<Person> GetPersonDAO()
        {
            return new PersonDAO(Context);
        }

        public static IDataAccess<Property> GetPropettyDAO()
        {
            return new PropertyDAO(Context);
        }

        public static IDataAccess<Provider> GetProviderDAO()
        {
            return new ProviderDAO(Context);
        }

        public static IDataAccess<Request> GetRequestDAO()
        {
            return new RequestDAO(Context);
        }
    }
}
