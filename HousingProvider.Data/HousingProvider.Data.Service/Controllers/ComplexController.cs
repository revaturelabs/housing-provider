﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Data.Service.Models;
using HousingProvider.Data.Library.DAO;
using Microsoft.EntityFrameworkCore;
using HousingProvider.Data.Service.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public class ComplexController : ProviderDBController
    {
        private EntityDTOMapper<Library.Models.Complex, Complex> _Mapper = new EntityDTOMapper<Library.Models.Complex, Complex>();

        public ComplexController(DbContext context) : base(context) { }

        [HttpGet]
        public IEnumerable<Complex> Get()
        {
            var comList = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context).Read();
            var dtos = new List<Complex>();
            foreach (var com in comList)
            {
                dtos.Add(_Mapper.MapToDTO(com));
            }
            return dtos;
        }

        [HttpPost]
        public void Post([FromBody] Complex com)
        {
            var comDAO = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context);
            comDAO.Create(_Mapper.MapFromDTO(com));
        }
    }
}
