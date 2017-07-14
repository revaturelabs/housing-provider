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
            Request RequestInDb;
            RequestInDb = _Context.Request.FirstOrDefault(x => x.RequestId == ObjectToBeDeleted.RequestId);

            if(RequestInDb != null)
            {
                _Context.Request.Remove(RequestInDb);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteById(int id)
        {
            Request RequestInDb;
            RequestInDb = _Context.Request.FirstOrDefault(x => x.RequestId == id);

            if (RequestInDb != null)
            {
                _Context.Request.Remove(RequestInDb);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

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
            List<Request> listRequests = _Context.Request.ToList();

            if (listRequests != null)
            {
                return listRequests;
            }

            return null;

        }

        public Request GetById(int id)
        {
            var Request = _Context.Request.FirstOrDefault(x => x.RequestId == id);

            if (Request != null)
            {
                return Request;
            }

            return null;
        }

        public bool Update(Request ObjectToBeUpdated)
        {
            Request RequestInDb;
            RequestInDb = _Context.Request.FirstOrDefault(x => x.RequestId == ObjectToBeUpdated.RequestId);

            if (RequestInDb != null)
            {
                RequestInDb = ObjectToBeUpdated;
                _Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
