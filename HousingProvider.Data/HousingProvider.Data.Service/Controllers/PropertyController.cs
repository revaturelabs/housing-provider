using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousingProvider.Data.Service.Mappers;
using HousingProvider.Data.Library.DAO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public class PropertyController : ProviderDBController
    {
        private EntityDTOMapper<Library.Models.Property, Models.Property> _Mapper = new EntityDTOMapper<Library.Models.Property, Models.Property>();

        public PropertyController(DbContext context) : base(context) { }
        
        [HttpGet("{guid}")]
        public IEnumerable<Models.Property> Get(string guid)
        {
            var complex = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context).Find(Guid.Parse(guid), new string[] { "Property" });
            var dtos = new List<Models.Property>();
            foreach (var prop in complex.Property)
            {
                dtos.Add(_Mapper.MapToDTO(prop));
            }
            return dtos;
        }
    }
}
