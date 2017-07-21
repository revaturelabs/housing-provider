using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Models;

namespace HousingProvider.Business.Service.Controllers
{
  [Route("api/[controller]")]
  public class ServiceController : Controller
    {
        public List<Complex> Get(Complex c)
        {
            return FactoryController<Complex>.Route(c.GetType().ToString(), c).Get();
        }
        public List<Request> Get(Request r)
        {
            return FactoryController<Request>.Route(r.GetType().ToString(), r).Get();
        }
        public bool Post(Request r)
        {
            return FactoryController<Request>.Route(r.GetType().Name, r).Post();
        }
    }
}