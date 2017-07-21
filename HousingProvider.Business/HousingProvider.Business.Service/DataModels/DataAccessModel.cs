using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HousingProvider.Business.Library.Interfaces;


namespace HousingProvider.Business.Service.DataModels
{
  public abstract class DataAccessModel<T> : DataModel<T> where T : ILibraryModel
  {
    
    internal DataAccessModel()
    {
      client.BaseAddress = new Uri("http://housingproviderdata.azurewebsites.net/api/complex");
    }
    
  }
}