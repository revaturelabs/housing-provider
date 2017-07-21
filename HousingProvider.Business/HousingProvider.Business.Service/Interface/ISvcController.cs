using HousingProvider.Business.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.Interface
{
    public interface ISvcController<T>
    {
    bool Post();
    List<T> Get();
    }
}
