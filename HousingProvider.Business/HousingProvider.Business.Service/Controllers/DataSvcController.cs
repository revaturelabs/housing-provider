using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Business.Service.Controllers
{
  [Route("api/[controller]")]
  public abstract class DataSvcController : Controller
  {
    protected string DataSvcUrl = "http://housingproviderdata.azurewebsites.net/api/";
  }
}