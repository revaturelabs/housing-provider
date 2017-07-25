using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Data.Library.Models;
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
        public ComplexController(HousingProviderDBContext context) : base(context) { }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Models.Complex> Get()
        {
            var comList = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context).Read();
            var dtos = new List<Models.Complex>();
            foreach (var com in comList)
            {
                dtos.Add(_Mapper.MapToDTO(com));
            }
            return dtos;

        }
    }
}
