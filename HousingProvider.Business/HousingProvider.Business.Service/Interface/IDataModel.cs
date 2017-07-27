using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.Interface
{
    public interface IDataModel<T> where T : ILibraryModel
    {
        List<T> GetAll();
        Guid Create(T obj);
    }
}
