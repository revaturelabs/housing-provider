using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class RequestTest
    {
        [Test]
        public void RequestTitleTest()
        {
            var c = new Request();
            c.RequestTitle = "Help";

            Assert.IsNotNull(c.RequestTitle);
        }

        [Test]
        public void RequestDescriptionTest()
        {
            var c = new Request();
            c.Description = "Help";

            Assert.IsNotNull(c.Description);
        }

        [Test]
        public void RequestDateTest()
        {
            var c = new Request();
            c.RequestDate = DateTime.Now;

            Assert.IsNotNull(c.RequestDate);
        }

        [Test]
        public void RequestDateModifiedTest()
        {
            var c = new Request();
            c.RequestModifiedDate = DateTime.Now;

            Assert.IsNotNull(c.RequestModifiedDate);
        }

        [Test]
        public void RequestorNameTest()
        {
            var c = new Request();
            c.RequestorName = "Help";

            Assert.IsNotNull(c.RequestorName);
        }

        [Test]
        public void RequestRepNameTest()
        {
            var c = new Request();
            c.RepresentitiveName = "Help";

            Assert.IsNotNull(c.RepresentitiveName);
        }

        [Test]
        public void RequestActionTest()
        {
            var c = new Request();
            c.Action = "Help";

            Assert.IsNotNull(c.Action);
        }

        [Test]
        public void RequestUrgentTest()
        {
            var c = new Request();
            c.Urgent = true;

            Assert.IsTrue(c.Urgent);
        }

        [Test]
        public void RequestActiveTest()
        {
            var c = new Request();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
