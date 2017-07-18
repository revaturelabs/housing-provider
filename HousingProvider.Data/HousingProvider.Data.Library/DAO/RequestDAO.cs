using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HousingProvider.Data.Library.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Library.DAO
{
    public class RequestDAO : AEntityDataAccess<Request>
    {
        public RequestDAO(DbContext context) : base(context) {}

        public override Request Get(Request model)
        {
            return _Context.Set<Request>().FirstOrDefault(r => r.RequestTitle == model.RequestTitle &&
                                                            r.RequestorName == model.RequestorName &&
                                                            r.RepresentativeName == model.RepresentativeName);
        }
    }
}
