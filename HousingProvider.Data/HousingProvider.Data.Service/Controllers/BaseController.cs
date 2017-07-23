using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {
        private DbContext _Context;

        protected DbContext Context { get { return _Context; } }

        public BaseController(DbContext context)
        {
            _Context = context;
        }
    }
}
