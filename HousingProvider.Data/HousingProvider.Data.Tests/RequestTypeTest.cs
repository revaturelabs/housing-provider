using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class RequestTypeTest
    {
        [Test]
        public void RequestTypeDescriptionTest()
        {
            var c = new RequestType();
            c.RequestTypeDescription = "Supply Request";

            Assert.IsNotNull(c.RequestTypeDescription);
        }

        [Test]
        public void RequestTypeActiveTest()
        {
            var c = new RequestType();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
