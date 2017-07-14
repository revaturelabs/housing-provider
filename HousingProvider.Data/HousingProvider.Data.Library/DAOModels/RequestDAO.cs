using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HousingProvider.Data.Library.DAOModels
{
    public class RequestDAO : ICrud<Request, string>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Request ObjectToBeAdded)
        {
            if(ObjectToBeAdded != null)
            {
                _Context.Request.Add(ObjectToBeAdded);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Request ObjectToBeDeleted)
        {
            throw new NotImplementedException();
        }

        //
        public Request Get(string title)
        {
            if(!string.IsNullOrEmpty(title))
            {
                Request request = _Context.Request.FirstOrDefault(x => x.RequestTitle == title);
                if(request != null)
                {
                    return request;
                }
            }
            return null;
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
