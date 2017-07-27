using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Models;
using HousingProvider.Business.Service.DataModels;

namespace HousingProvider.Business.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Property")]
    public class PropertyController : DataSvcController
    {
        public PropertyController()
        {
            DataSvcUrl += "property";
        }
        
        [HttpGet("{guid}")]
        public IEnumerable<Property> Get(string guid)
        {
            return DataFactory<Property>.Access(DataSvcUrl).GetAllByGuid(Guid.Parse(guid));
        }

        [HttpPost]
        public Guid Post([FromBody] Property prop)
        {
            return DataFactory<Property>.Access(DataSvcUrl).Create(prop);
        }
    }
}
