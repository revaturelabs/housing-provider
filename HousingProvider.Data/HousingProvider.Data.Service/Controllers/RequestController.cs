using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Data.Library;
using HousingProvider.Data.Library.Models;

using Microsoft.Net.Http;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Service.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
    public class RequestController : BaseController
    {
        public RequestController(DbContext context) : base(context) { }

        [HttpGet]
        public string Get()
        {
            return "legitimate database data";
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]Request request)
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}
