using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousingProvider.Data.Service.Mappers;
using HousingProvider.Data.Service.Models;
using HousingProvider.Data.Library.DAO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    public class AddressController : ProviderDBController
    {
        private EntityDTOMapper<Library.Models.Address, Address> _Mapper = new EntityDTOMapper<Library.Models.Address, Address>();

        public AddressController(DbContext context) : base(context) { }

        [HttpGet("{guid}")]
        public Address Get(string guid)
        {
            var complex = DataAccessFactory.GetDataAccessObject<Library.Models.Complex>(Context).Find(Guid.Parse(guid), new string[] { "Address" });
            var property = DataAccessFactory.GetDataAccessObject<Library.Models.Property>(Context).Find(Guid.Parse(guid), new string[] { "Address" });
            if (complex != null)
            {
                return _Mapper.MapToDTO(complex.Address);
            }
            else if (property != null)
            {
                return _Mapper.MapToDTO(property.Address);
            }
            return null;
        }
    }
}
