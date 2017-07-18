﻿using System;
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

        // GET: api/values
        [HttpGet]
        public Task<List<Request>> Get()
        {
            return rb.Get();
        }

        /*// GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]Request req)
        {
            return rb.Create(req);
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
