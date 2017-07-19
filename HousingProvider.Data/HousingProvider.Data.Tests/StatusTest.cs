using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class StatusTest
    {
        [Test]
        public void StatusDescriptionTest()
        {
            var c = new Status();
            c.StatusDescription = "Completed";

            Assert.IsNotNull(c.StatusDescription);
        }

        [Test]
        public void StatusActiveTest()
        {
            var c = new Status();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
