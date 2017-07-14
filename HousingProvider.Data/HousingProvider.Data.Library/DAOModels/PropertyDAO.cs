using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class PropertyDAO : ICrud<Property, Address>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Property ObjectToBeAdded)
        {
            if (ObjectToBeAdded != null)
            {
                _Context.Property.Add(ObjectToBeAdded);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Property ObjectToBeDeleted)
        {
            Property PropertyInDb;

            PropertyInDb = _Context.Property.FirstOrDefault(x => x.AddressId == ObjectToBeDeleted.AddressId);

            if(PropertyInDb != null)
            {
                _Context.Property.Remove(PropertyInDb);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public Property Get(Address obj)
        {
            if(obj != null)
            {
                return _Context.Property.FirstOrDefault(x => x.AddressId == obj.AddressId);
            }

            return null;
        }

        public List<Property> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Property ObjectToBeUpdated)
        {
            Property PropertyInDb;

            PropertyInDb = _Context.Property.FirstOrDefault(x => x.AddressId == ObjectToBeUpdated.AddressId);

            if (PropertyInDb != null)
            {
                PropertyInDb = ObjectToBeUpdated;
                _Context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
