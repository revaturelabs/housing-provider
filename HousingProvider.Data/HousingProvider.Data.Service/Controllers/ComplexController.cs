﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Data.Library.EFModels;
using HousingProvider.Data.Library.DAO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public class ComplexController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Complex> Get()
        {
            return DataAccessFactory.GetComplexDAO().Read();
        }
    }
}