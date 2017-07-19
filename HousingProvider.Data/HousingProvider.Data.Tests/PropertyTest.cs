using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class PropertyTest
    {
        [Test]
        public void PropertyNumberOfRoomsTest()
        {
            var c = new Property();
            c.NumberOfRooms = 3;

            Assert.IsNotNull(c.NumberOfRooms);
        }

        [Test]
        public void PropertyNumberOfBathsTest()
        {
            var c = new Property();
            c.NumberOfBaths = 2;

            Assert.IsNotNull(c.NumberOfBaths);
        }

        [Test]
        public void PropertyActiveTest()
        {
            var c = new Property();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }

        [Test]
        public void PropertyAddressTest()
        {
            var c = new Property();
            c.Address = new Address(); ;

            Assert.IsNotNull(c.Address);
        }
    }
}
