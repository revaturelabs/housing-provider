﻿using HousingProvider.Data.Library.Abstracts;
using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Library.DAO
{
    public class ProviderDAO : AEntityDataAccess<Provider>
    {
        public ProviderDAO(DbContext context) : base(context) {}

        public override Provider Get(Provider model)
        {
            return _Context.Set<Provider>().FirstOrDefault(p => p.ProviderName == model.ProviderName);
        }
    }
}
