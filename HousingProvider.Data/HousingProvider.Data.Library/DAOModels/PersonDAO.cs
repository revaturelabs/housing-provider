using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class PersonDAO : ICrud<Person, string>
    {
        public bool Add(Person ObjectToBeAdded)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Person ObjectToBeDeleted)
        {
            throw new NotImplementedException();
        }

        public Person Get(string obj)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Person ObjectToBeUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
