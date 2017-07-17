using HousingProvider.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Tests
{
    [TestFixture]
    public class BusinessRequestTest
    {
        [Test]
        public void RequestEqualsPositiveTest()
        {
            var request1 = new Request {
                Description = "Bedroom door broken",
                Initiator = "Felice",
                Provider = "Housing LLC",
                DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
                Title = "Broken door",
                Status = StatusEnum.PENDING
            };

            var request2 = new Request
            {
                Description = "Bedroom door broken",
                Initiator = "Felice",
                Provider = "Housing LLC",
                DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
                Title = "Broken door",
                Status = StatusEnum.INWORK
            };

            Assert.IsTrue(request1.Equals(request2));
        }

        [Test]
        public void RequestEqualsNegativeTest()
        {
            var request1 = new Request
            {
                Description = "Bedroom door broken",
                Initiator = "Felice",
                Provider = "Housing LLC",
                DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
                Title = "Broken door",
            };

            var request2 = new Request
            {
                Description = "Bedroom door Will not close",
                Initiator = "Felice",
                Provider = "Housing LLC",
                DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
                Title = "Broken door",
            };

            Assert.IsFalse(request1.Equals(request2));
         }
   }
}
