using AutoMapper;
using HousingProvider.Data.Library.Models;
using HousingProvider.Data.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Mappers
{
    public class ComplexMapper
    {
        private MapperConfiguration _ToDTO = new MapperConfiguration(cfg => cfg.CreateMap<Library.Models.Complex, Models.Complex>());

        public Models.Complex MapToDTO(Library.Models.Complex com)
        {
            return _ToDTO.CreateMapper().Map<Models.Complex>(com);
        }
    }
}
