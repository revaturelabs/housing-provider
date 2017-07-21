using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.DataModels
{
    public class DataFactory<T>  where T: ILibraryModel
    {
      public static DataModel<T> Access()
      {
        return new DataModel<T>();
      }
    }
}
