using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.Interface
{
    public interface ICrud
    {
        List<Object> Get();
        bool Create(Object obj);
        bool Delete(Object obj);
        bool Update(Object obj);

    }
}
