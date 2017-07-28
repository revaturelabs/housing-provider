using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Models;
using HousingProvider.Business.Service.DataModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Business.Service.Controllers
{
    [Route("api/[controller]")]
    public class ComplexController : DataSvcController
    {
        public ComplexController()
        {
            DataSvcUrl += "complex";
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Complex> Get()
        {
            return DataFactory<Complex>.Access(DataSvcUrl).GetAll();
        }

        [HttpGet("{guid}")]
        public Complex Get(string guid)
        {
            return DataFactory<Complex>.Access(DataSvcUrl).FindByGuid(Guid.Parse(guid));
        }

        [HttpPost]
        public Guid Post([FromBody] Complex com)
        {
            return DataFactory<Complex>.Access(DataSvcUrl).Create(com);
        }
    }
}