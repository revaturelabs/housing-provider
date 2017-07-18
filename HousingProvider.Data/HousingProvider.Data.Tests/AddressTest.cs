using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class AddressTest
    {
        [Test]
        public void AddressStreet1()
        {
            var c = new Address();
            c.Street1 = "Wordsworth ct";

            Assert.IsNotNull(c.Street1);
        }

        [Test]
        public void AddressApartmentNum()
        {
            var c = new Address();
            c.ApartmentNum = 123;

            Assert.IsNotNull(c.ApartmentNum);
        }

        [Test]
        public void AddressCity()
        {
            var c = new Address();
            c.City = "Herndon";

            Assert.IsNotNull(c.City);
        }

        [Test]
        public void AddressState()
        {
            var c = new Address();
            c.State = "Virginia";

            Assert.IsNotNull(c.State);
        }

        [Test]
        public void AddressZipCode()
        {
            var c = new Address();
            c.ZipCode = "1234";

            Assert.IsNotNull(c.ZipCode);
        }

        [Test]
        public void AddressActive()
        {
            var c = new Address();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
