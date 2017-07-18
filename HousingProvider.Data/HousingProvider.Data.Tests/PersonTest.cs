using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void PersonFirstNameTest()
        {
            var c = new Person();
            c.FirstName = "John";

            Assert.IsNotNull(c.FirstName);
        }

        [Test]
        public void PersonLastNameTest()
        {
            var c = new Person();
            c.LastName = "Smith";

            Assert.IsNotNull(c.LastName);
        }

        [Test]
        public void PersonActiveTest()
        {
            var c = new Person();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
