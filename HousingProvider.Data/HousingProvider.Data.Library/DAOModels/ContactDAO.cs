using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class ContactDAO : ICrud<Contact, string>
    {
        public HousingProviderDBContext _Context = new HousingProviderDBContext();

        public bool Add(Contact ObjectToBeAdded)
        {
            if(ObjectToBeAdded != null)
            {
                _Context.Add(ObjectToBeAdded);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Contact ObjectToBeDeleted)
        {
            Contact ContactInDB;

            ContactInDB = _Context.Contact.FirstOrDefault(x => x.Email == ObjectToBeDeleted.Email);

            if(ContactInDB  != null)
            {
                _Context.Contact.Remove(ContactInDB);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool DeleteById(int id)
        {
            Contact ContactInDB;
            ContactInDB = _Context.Contact.FirstOrDefault(x => x.ContactId == id);

            if (ContactInDB != null)
            {
                _Context.Contact.Remove(ContactInDB);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

        public Contact Get(string obj)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contact ObjectToBeUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
