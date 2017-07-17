using HousingProvider.Business.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library
{
    public interface IProperty
    {
        bool AddRequest(Request newRequest);

        List<Request> GetOpenRequests();
    }
}
