using AutoMapper;
using HousingProvider.Data.Library.Models;
using HousingProvider.Data.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Mappers
{
    public class EntityMapper <T, U>
    {
        private MapperConfiguration _ToDTO = new MapperConfiguration(cfg => cfg.CreateMap<T, U>());

        public U MapToDTO(T com) 
        {
            return _ToDTO.CreateMapper().Map<T, U>(com);
        }
    }
}
