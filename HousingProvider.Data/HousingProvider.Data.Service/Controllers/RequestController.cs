using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Data.Library;
using HousingProvider.Data.Library.EFModels;

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public class RequestController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<Request> Get()
        {
            //DaoHandler handler = new DaoHandler();
            //var requests = handler.RequestDao.GetAll();
            //return requests;
            throw new NotImplementedException();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Request request)
        {
            if(request!=null)
            {
                DaoHandler handler = new DaoHandler();
                //handler.RequestDao.Add(request);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
