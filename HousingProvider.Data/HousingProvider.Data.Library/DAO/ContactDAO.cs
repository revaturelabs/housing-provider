﻿using HousingProvider.Data.Library.Abstracts;
using HousingProvider.Data.Library.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Library.DAO
{
    public class ContactDAO : AEntityDataAccess<Contact>
    {
        public ContactDAO(DbContext context) : base(context) {}

        public override Contact Get(Contact model)
        {
            return _Context.Set<Contact>().FirstOrDefault(c => c.Phone == model.Phone &&
                                                            c.Email == model.Email);
        }
    }
}