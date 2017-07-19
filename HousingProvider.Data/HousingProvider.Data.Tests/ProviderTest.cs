using HousingProvider.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class ProviderTest
    {
        [Test]
        public void ProviderNameTest()
        {
            var c = new Provider();
            c.ProviderName = "BridgeStreet";

            Assert.IsNotNull(c.ProviderName);
        }

        [Test]
        public void ProviderActiveTest()
        {
            var c = new Provider();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }
    }
}
