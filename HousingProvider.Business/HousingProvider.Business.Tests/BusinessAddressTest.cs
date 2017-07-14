using HousingProvider.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Tests
{
    [TestFixture]
    public class BusinessAddressTest
    {
        [Test]
        public void AddressEqualsPositiveTest()
        {
            var address1 = new Address
            {
                Address1 = "4001 America Ln.",
                ApartmentNumber = "2B",
                City = "Reston",
                State = "VA",
                ZipCode = "25334"
            };

            var address2 = new Address
            {
                Address1 = "4001 America Ln.",
                ApartmentNumber = "2B",
                City = "Reston",
                State = "VA",
                ZipCode = "25334"
            };

            Assert.IsTrue(address1.Equals(address2));
        }
        
        [Test]
        public void AddressEqualsNegativeTest()
        {
            var address1 = new Address
            { 
                Address1 = "4001 America Ln.",
                ApartmentNumber = "2B",
                City = "Reston",
                State = "VA",
                ZipCode = "25334"
            };

            var address2 = new Address
            {
                Address1 = "4001 America Ln.",
                ApartmentNumber = "2A",
                City = "Reston",
                State = "VA",
                ZipCode = "25334"
            };

            Assert.IsFalse(address1.Equals(address2));
        }
    }
}
