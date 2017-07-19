using HousingProvider.Data.Library.DAO;
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

        public static IDataAccess<Address> GetAddressDAO()
        {
            return new AddressDAO(_Context);
        }

        public static IDataAccess<Contact> GetContextDAO()
        {
            return new ContactDAO(_Context);
        }

        public static IDataAccess<Person> GetPersonDAO()
        {
            return new PersonDAO(_Context);
        }

        public static IDataAccess<Property> GetPropettyDAO()
        {
            return new PropertyDAO(_Context);
        }

        public static IDataAccess<Provider> GetProviderDAO()
        {
            return new ProviderDAO(_Context);
        }

        public static IDataAccess<Request> GetRequestDAO()
        {
            return new RequestDAO(_Context);
        }
    }
}
