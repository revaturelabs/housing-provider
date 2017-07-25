using AutoMapper;
using HousingProvider.Data.Library.Models;
using HousingProvider.Data.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Mappers
{
    public class EntityDTOMapper <T, U>
    {
        private MapperConfiguration _MCfg = new MapperConfiguration(cfg => { cfg.CreateMap<T, U>();
                                                                     cfg.CreateMap<U, T>(); });

        public U MapToDTO(T entity) 
        {
            return _MCfg.CreateMapper().Map<T, U>(entity);
        }

        public T MapFromDTO(U entity)
        {
            return _MCfg.CreateMapper().Map<U, T>(entity);
        }
    }
}
