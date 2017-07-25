﻿using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    public class Address : ILibraryModel
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ApartmentNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public override bool Equals(object obj)
        {
            if(obj != null && obj.GetType() == GetType())
            {
                var newAddress = obj as Address;
                return newAddress.ApartmentNumber.ToLower().Equals(ApartmentNumber.ToLower()) &&
                   newAddress.Address1.ToLower().Equals(Address1.ToLower()) &&
                   newAddress.City.ToLower().Equals(City.ToLower()) &&
                   newAddress.State.ToLower().Equals(State.ToLower()) &&
                   newAddress.ZipCode.ToLower().Equals(ZipCode.ToLower());
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Address1.GetHashCode() +
               ApartmentNumber.GetHashCode() +
               City.GetHashCode() +
               State.GetHashCode() +
               ZipCode.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} Apt {1},\n{2} {3} {4}",
               Address1,ApartmentNumber,City,State,ZipCode);
        }
   }
}
