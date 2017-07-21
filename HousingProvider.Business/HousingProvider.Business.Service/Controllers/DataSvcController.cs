using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Service.Interface;
using HousingProvider.Business.Library.Interfaces;
using HousingProvider.Business.Service.DataModels;
using HousingProvider.Business.Library.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Business.Service.Controllers
{
  
  public class DataSvcController<T> : Controller, ISvcController<T> where T : ILibraryModel
  {
    protected string DataSvcUrl = "http://housingproviderdata.azurewebsites.net/api/";
    T OBJ;
    internal DataSvcController(string route, T obj)
    {
      DataSvcUrl += route;
      OBJ = obj;
    }
    public List<T> Get()
    {
      return DataFactory<T>.Access(DataSvcUrl).GetAll();
    }

    public bool Post()
    {
      return DataFactory<T>.Access(DataSvcUrl).Create(OBJ);
    }
  }
}

