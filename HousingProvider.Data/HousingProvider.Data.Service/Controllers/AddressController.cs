using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousingProvider.Data.Service.Mappers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Data.Service.Controllers
{
    public class AddressController : ProviderDBController
    {
        private EntityDTOMapper<Library.Models.Address, Models.Address> _Mapper = new EntityDTOMapper<Library.Models.Address, Models.Address>();

        public AddressController(DbContext context) : base(context) { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
