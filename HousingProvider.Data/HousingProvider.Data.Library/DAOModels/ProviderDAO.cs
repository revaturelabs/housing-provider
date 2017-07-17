using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingProvider.Data.Library.DAOModels
{
    public class ProviderDAO : ICrud<Provider, string>
    {
        private HousingProviderDBContext _Context = ContextFactory.GetContext();

        public bool Add(Provider ObjectToBeAdded)
        {
            if (ObjectToBeAdded != null)
            {
                _Context.Provider.Add(ObjectToBeAdded);
                _Context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(Provider ObjectToBeDeleted)
        {
            Provider ProviderInDb;

            ProviderInDb = _Context.Provider.FirstOrDefault( x => x.ProviderName == ObjectToBeDeleted.ProviderName);

            if(ProviderInDb != null)
            {
                _Context.Provider.Remove(ProviderInDb);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteById(int id)
        {
            Provider ProviderInDb;

            ProviderInDb = _Context.Provider.FirstOrDefault(x => x.ProviderId == id);

            if (ProviderInDb != null)
            {
                _Context.Provider.Remove(ProviderInDb);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }

        public Provider Get(string obj)
        {
            Provider Provider= _Context.Provider.FirstOrDefault(x => x.ProviderName == obj);
            if(Provider != null)
            {
                return Provider;
            }
            return null;
        }

        public List<Provider> GetAll()
        {
            throw new NotImplementedException();
        }

        public Provider GetById(int id)
        {
            var Provider = _Context.Provider.FirstOrDefault(x => x.ProviderId == id);

            if (Provider != null)
            {
                return Provider;
            }

            return null;
        }

        public bool Update(Provider ObjectToBeUpdated)
        {
            Provider ProviderInDb;

            ProviderInDb = _Context.Provider.FirstOrDefault(x => x.ProviderId == ObjectToBeUpdated.ProviderId);

            if (ProviderInDb != null)
            {
                ProviderInDb = ObjectToBeUpdated;
                _Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
