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
    [Route("api/Address")]
    public class AddressController : DataSvcController
    {
        public AddressController()
        {
            DataSvcUrl += "address";
        }

        [HttpGet("{guid}")]
        public Address Get(string guid)
        {
            return DataFactory<Address>.Access(DataSvcUrl).FindByGuid(Guid.Parse(guid));
        }

        [HttpPost]
        public Guid Post([FromBody] Address adr)
        {
            return DataFactory<Address>.Access(DataSvcUrl).Create(adr);
        }
    }
}
