using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class AddressDAO : ICrud<Address, string>
    {
        public bool Add(Address ObjectToBeAdded)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Address ObjectToBeDeleted)
        {
            throw new NotImplementedException();
        }

        public Address Get(string obj)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Address ObjectToBeUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
