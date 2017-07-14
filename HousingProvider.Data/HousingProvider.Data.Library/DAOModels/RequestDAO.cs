using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class RequestDAO : ICrud<Request, string>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Request ObjectToBeAdded)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Request ObjectToBeDeleted)
        {
            throw new NotImplementedException();
        }

        public Request Get(string obj)
        {
            throw new NotImplementedException();
        }

        public List<Request> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Request ObjectToBeUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
