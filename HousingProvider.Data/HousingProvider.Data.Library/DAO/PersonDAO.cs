using HousingProvider.Data.Library.Abstracts;
using HousingProvider.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Library.DAO
{
    public class PersonDAO : AEntityDataAccess<Person>
    {
        public PersonDAO(DbContext context) : base(context) {}

        public override Person Get(Person model)
        {
            return _Context.Set<Person>().FirstOrDefault(p => p.FirstName == model.FirstName && 
                                                            p.LastName == model.LastName);
        }
    }
}
