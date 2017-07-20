using HousingProvider.Data.Library.Abstracts;
using HousingProvider.Data.Library.Interfaces;
using HousingProvider.Data.Library.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HousingProvider.Data.Library.DAO
{
    public class PropertyDAO : EntityDataAccess<Property>
    {
        public PropertyDAO(DbContext context) : base(context) {}

        public override Property Get(Property model)
        {
            var mAdr = model.Address;
            return _Context.Set<Property>().FirstOrDefault(p => p.Address.Street1 == mAdr.Street1 &&
                                                            p.Address.Street2 == mAdr.Street2 &&
                                                            p.Address.ApartmentNum == mAdr.ApartmentNum &&
                                                            p.Address.City == mAdr.City &&
                                                            p.Address.State == mAdr.State &&
                                                            p.Address.ZipCode == mAdr.ZipCode);
            throw new NotImplementedException();
        }
    }
}
