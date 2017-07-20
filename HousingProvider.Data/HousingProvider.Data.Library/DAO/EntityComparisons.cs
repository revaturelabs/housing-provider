using HousingProvider.Data.Library.EFModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.DAO
{
    public static class EntityComparisons
    {
        public static bool AddressEquals(Address adr1, Address adr2)
        {
            return adr1.Street1 == adr2.Street1 &&
                   adr1.Street2 == adr2.Street2 &&
                   adr1.ApartmentNum == adr2.ApartmentNum &&
                   adr1.City == adr2.City &&
                   adr1.State == adr2.State &&
                   adr1.ZipCode == adr2.ZipCode;
        }
    }
}
