using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Interfaces;

namespace HousingProvider.Business.Service.Controllers
{
    public class FactoryController<T> where T: ILibraryModel
    {
        public static DataSvcController<T> Route(string route, T obj) 
        {
            return new DataSvcController<T>(route,obj);
        }
    }
}