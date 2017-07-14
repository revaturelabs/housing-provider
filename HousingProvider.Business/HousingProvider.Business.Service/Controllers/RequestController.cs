using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Models;
using Newtonsoft.Json;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Business.Service.Controllers
{
    [Route("api/[controller]")]
    public class RequestController : Controller
    {
        private static RequestBroker rb = new RequestBroker();
        private static string url = "http://localhost:58058/api/";
        private static HttpClient client = new HttpClient { BaseAddress = new Uri (url) };
        // GET: api/values
        [HttpGet]
        public Task<List<Request>> Get()
        {
            //var output = new List<Request> ();
            ////return new List<Request> ();
            //output = rb.Get ();
            return rb.Get ();
        }
        //public async Task<List<Request>> Get()
        //{
        //    var list = new List<Request> ();

        //    try
        //    {
        //        var response = await client.GetAsync ("request", HttpCompletionOption.ResponseContentRead);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            list = JsonConvert.DeserializeObject<List<Request>> (response.Content.ReadAsStringAsync ().Result);
        //        }
        //    }
        //    catch
        //    {

        //    }

        //    return list;
        //}

        /*// GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Request req)
        {
        }

        /*// PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
