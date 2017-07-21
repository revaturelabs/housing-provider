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
    public class ComplexController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Complex> Get()
        {
            return DataFactory<Complex>.Access().GetAll();
        }
    }
}
