using HousingProvider.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Tests
{
    [TestFixture]
    public class BusinessPropertyTest
    {
        [Test]
        public void PropertyAddRequestPositiveTest()
        {
            var property = new Property();
            property.AddRequest(new Request());

            var actual = property.Requests.Count;

            Assert.IsTrue(actual > 0);
        }
        
        [Test]
        public void PropertyEqualsPositiveTest()
        {
            var property1 = new Property
            {
                Address = new Address
                {
                    Address1 = "4001 America Ln.",
                    ApartmentNumber = "2B",
                    City = "Reston",
                    State = "VA",
                    ZipCode = "25334"
                }
            };

            var property2 = new Property
            {
                Address = new Address
                {
                    Address1 = "4001 America Ln.",
                    ApartmentNumber = "2B",
                    City = "Reston",
                    State = "VA",
                    ZipCode = "25334"
                }
            };

            Assert.IsTrue(property1.Equals(property2));
        }

         [Test]
         public void PropertyEqualsNegativeTest()
         {
             var property1 = new Property
             {
                 Address = new Address
                 {
                     Address1 = "4001 America Ln.",
                     ApartmentNumber = "2A",
                     City = "Reston",
                     State = "VA",
                     ZipCode = "25334"
                 }
             };

             var property2 = new Property
             {
                 Address = new Address
                 {
                     Address1 = "4001 America Ln.",
                     ApartmentNumber = "2B",
                     City = "Reston",
                     State = "VA",
                     ZipCode = "25334"
                 }
             };

             Assert.IsFalse(property1.Equals(property2));
         }
        
        [Test]
        public void PropertyGetOpenRequestsTest()
        {
            var property = new Property();

            var request1 = new Request
            {
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


            var request3 = new Request
            {
               Description = "Front door broken",
               Initiator = "Felice",
               Provider = "Housing LLC",
               DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
               Title = "Broken door",
               Status = StatusEnum.COMPLETED
            };

            property.AddRequest(request1);
            property.AddRequest(request2);
            property.AddRequest(request3);

            var actual = property.GetOpenRequests().Count;

            Assert.IsTrue(actual == 1);
        }
    }
}

