using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class PropertyDAO : ICrud<Property, Address>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Property ObjectToBeAdded)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Property ObjectToBeDeleted)
        {
            throw new NotImplementedException();
        }

        public Property Get(Address obj)
        {
            throw new NotImplementedException();
        }

        public List<Property> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Property ObjectToBeUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
