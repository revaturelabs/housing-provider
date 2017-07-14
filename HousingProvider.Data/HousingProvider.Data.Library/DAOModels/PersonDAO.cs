﻿using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class PersonDAO : ICrud<Person, string>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Person ObjectToBeAdded)
        {
            if (ObjectToBeAdded != null)
            {
                _Context.Person.Add(ObjectToBeAdded);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Person ObjectToBeDeleted)
        {
            Person PersonInDb;

            PersonInDb = _Context.Person.FirstOrDefault(x => (x.FirstName == ObjectToBeDeleted.FirstName) && (x.LastName == ObjectToBeDeleted.LastName));

            if(PersonInDb != null)
            {
                _Context.Person.Remove(PersonInDb);
                return true;
            }
            return false;
        }

        public bool DeleteById(int id)
        {

            Person PersonInDb;

            PersonInDb = _Context.Person.FirstOrDefault(x => x.PersonId == id);

            if (PersonInDb != null)
            {
                _Context.Person.Remove(PersonInDb);
                return true;
            }
            return false;
        }

        public Person Get(string FullName)
        {
            char[] delimeter = { ' ' };
            string[] names = FullName.Split(delimeter);

            var Person = _Context.Person.FirstOrDefault(x => x.FirstName == names[0] && x.LastName == names[1]);

            if(Person!=null)
            {
                return Person;
            }
            return null;
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            var Person = _Context.Person.FirstOrDefault(x => x.PersonId == id);

            if (Person != null)
            {
                return Person;
            }

            return null;
        }

        public bool Update(Person ObjectToBeUpdated)
        {
            Person PersonInDb;

            PersonInDb = _Context.Person.FirstOrDefault(x => (x.FirstName == ObjectToBeUpdated.FirstName) && (x.LastName == ObjectToBeUpdated.LastName));

            if (PersonInDb != null)
            {
                PersonInDb = ObjectToBeUpdated;
                _Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
