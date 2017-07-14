﻿using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HousingProvider.Data.Library.DAOModels
{
    public class AddressDAO : ICrud<Address, Address>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Address ObjectToBeAdded)
        {
            if (ObjectToBeAdded != null)
            {
                _Context.Address.Add(ObjectToBeAdded);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Address ObjectToBeDeleted)
        {
            Address AddressInDb;

            AddressInDb = _Context.Address.FirstOrDefault(x => (x.Street1 == ObjectToBeDeleted.Street1) && (x.Street2 == ObjectToBeDeleted.Street2) && (x.ApartmentNum == ObjectToBeDeleted.ApartmentNum));

            if (AddressInDb != null)
            { 
                _Context.Address.Remove(AddressInDb);
                _Context.SaveChanges();
                return true;
            }

            return false;
            
        }
        
        public Address Get(Address Addr)
        {
            var Address = _Context.Address.FirstOrDefault(x => (x.Street1 == Addr.Street1) && (x.Street2 == Addr.Street2) && (x.ApartmentNum == Addr.ApartmentNum));

            if(Address != null)
            {
                return Address;
            }

            return null;
            
        }

        public List<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {

            var Address = _Context.Address.FirstOrDefault(x => x.AddressId == id);

            if (Address != null)
            {
                return Address;
            }

            return null;
        }

        public bool Update(Address ObjectToBeUpdated)
        {
            Address AddressInDb;

            AddressInDb = _Context.Address.FirstOrDefault(x => (x.Street1 == ObjectToBeUpdated.Street1) && (x.Street2 == ObjectToBeUpdated.Street2) && (x.ApartmentNum == ObjectToBeUpdated.ApartmentNum));

            if (AddressInDb != null)
            {
                AddressInDb = ObjectToBeUpdated;
                _Context.SaveChanges();
                return true;
            }

            return false;

        }
    }
}
