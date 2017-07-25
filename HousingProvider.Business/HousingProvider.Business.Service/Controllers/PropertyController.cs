using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<string> Get(string guid)
        {
            throw new NotImplementedException();
        }
    }
}
