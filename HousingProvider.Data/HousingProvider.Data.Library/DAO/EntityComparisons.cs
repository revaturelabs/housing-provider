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

        public static bool ContactEquals(Contact con1, Contact con2)
        {
            return con1.Phone == con2.Phone && con1.Email == con2.Email;
        }

        public static bool PersonEquals(Person per1, Person per2)
        {
            return per1.FirstName == per2.FirstName && per1.LastName == per2.LastName;
        }

        public static bool PropertyEquals(Property prop1, Property prop2)
        {
            return AddressEquals(prop1.Address, prop2.Address);
        }

        public static bool RequestEquals(Request req1, Request req2)
        {
            return req1.RequestTitle == req2.RequestTitle &&
                req1.RequestorName == req2.RequestorName &&
                req2.RepresentativeName == req2.RepresentativeName;
        }
    }
}
