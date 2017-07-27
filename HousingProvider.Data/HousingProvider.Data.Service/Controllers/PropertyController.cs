using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousingProvider.Data.Service.Mappers;
using HousingProvider.Data.Library.DAO;
using HousingProvider.Data.Service.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    [Route("api/[controller]")]
    public class PropertyController : ProviderDBController
    {
        private EntityDTOMapper<Library.Models.Property, Property> _Mapper = new EntityDTOMapper<Library.Models.Property, Property>();

        public PropertyController(DbContext context) : base(context) { }
        
        [HttpGet("{guid}")]
        public IEnumerable<Property> Get(string guid)
        {
            var complex = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context).Find(Guid.Parse(guid), new string[] { "Property" });
            var dtos = new List<Property>();
            foreach (var prop in complex.Property)
            {
                dtos.Add(_Mapper.MapToDTO(prop));
            }
            return dtos;
        }

        [HttpPost]
        public Guid Post([FromBody] Property prop)
        {
            var efProp = _Mapper.MapFromDTO(prop);
            efProp.AddressId = DataAccessFactory.GetDataAccessObject<Library.Models.Address>(Context).Find(prop.AddressGuid).AddressId;
            efProp.ComplexId = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context).Find(prop.ComplexGuid).ComplexId;
            efProp.ProviderId = 1;
            efProp.Guid = Guid.NewGuid();
            efProp.ModifiedDate = DateTime.Now;
            efProp.Active = true;
            return DataAccessFactory.GetDataAccessObject<Library.Models.Property>(Context).Create(efProp).Guid;
        }
    }
}
