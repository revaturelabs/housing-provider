using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class ComplexTest
    {
        [Test]
        public void ComplexNameTest()
        {
            var c = new Complex();
            c.ComplexName = "Westerly";

            Assert.IsNotNull(c.ComplexName);
        }

        [Test]
        public void ComplexActiveTest()
        {
            var c = new Complex();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }

        [Test]
        public void ComplexAddressTest()
        {
            var c = new Complex();
            c.Address = new Address();

            Assert.IsNotNull(c.Address);
        }
    }
}
