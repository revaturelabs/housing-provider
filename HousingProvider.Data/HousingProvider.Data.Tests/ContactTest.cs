using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class ContactTest
    {
        [Test]
        public void ContactEmailTest()
        {
            var c = new Contact();
            c.Email = "jSmith@Gmail.com";

            Assert.IsNotNull(c.Email);
        }

        [Test]
        public void ContactPhoneTest()
        {
            var c = new Contact();
            c.Phone = "123456789";

            Assert.IsNotNull(c.Phone);
        }

        [Test]
        public void ContactActiveTest()
        {
            var c = new Contact();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
