using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Models;
using HousingProvider.Business.Service.DataModels;

using Newtonsoft.Json;
using System.Net.Http;
using HousingProvider.Business.Library.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Business.Service.Controllers
{
    [Route("api/[controller]")]
    public class RequestController : Controller 
    {
        [HttpPost]
        public bool Post([FromBody]Request req)
        {
          return DataFactory<Request>.Access().Create(req);
        }
    }
}
