using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousingProvider.Data.Library.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public abstract class ProviderDBController : Controller
    {
        private DbContext _Context;

        protected DbContext Context { get { return _Context; } }

        public ProviderDBController(DbContext context)
        {
            _Context = context;
        }
    }
}
