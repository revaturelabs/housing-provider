using HousingProvider.Data.Library.EFModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HousingProvider.Data.Library.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Library.DAO
{
    public class AddressDAO : EntityDataAccess<Address>
    {
        public AddressDAO(DbContext context) : base(context) {}

        public override Address Get(Address model)
        {
            return _Context.Set<Address>().FirstOrDefault(a => a.Street1 == model.Street1 &&
                                                            a.Street2 == model.Street2 &&
                                                            a.ApartmentNum == model.ApartmentNum &&
                                                            a.City == model.City &&
                                                            a.State == model.State &&
                                                            a.ZipCode == model.ZipCode);
        }
    }
}
