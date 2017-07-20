using HousingProvider.Business.Library.Interfaces;
using HousingProvider.Business.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.DataModels
{
  public class DataModel<T> : ICrud<T> where T:ILibraryModel
  {
    protected HttpClient client = new HttpClient();
    public virtual bool Create(T obj)
    {
      var json = JsonConvert.SerializeObject(obj);
      
      var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
      var response = client.PostAsync(client.BaseAddress.AbsoluteUri, content).Result;
        if (response.IsSuccessStatusCode)
        {
          return true;
        }
      else
      {
        return false;
      }
    
    }
  }
}
