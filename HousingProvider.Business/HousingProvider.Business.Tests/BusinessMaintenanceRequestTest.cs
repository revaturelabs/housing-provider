using HousingProvider.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Tests
{
    [TestFixture]
    public class BusinessMaintenanceRequestTest
   {
      [Test]
      public void MaintenanceRequestEqualsPositiveTest()
      {
         var request1 = new MaintenanceRequest
         {
            Description = "Bedroom door broken",
            Initiator = "Felice",
            Provider = "Housing LLC",
            DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
            Title = "Broken door",
            Status = StatusEnum.PENDING,
            PropertyAddress = new Address { Address1 = "21 D st.", ApartmentNumber = "2A", City = "Reston", State = "VA", ZipCode = "12345" }
         };

         var request2 = new MaintenanceRequest
         {
            Description = "Bedroom door broken",
            Initiator = "Felice",
            Provider = "Housing LLC",
            DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
            Title = "Broken door",
            Status = StatusEnum.INWORK,
            PropertyAddress = new Address { Address1 = "21 D st.", ApartmentNumber = "2A", City = "Reston", State = "VA", ZipCode = "12345" }
         };

         Assert.IsTrue(request1.Equals(request2));
      }

      [Test]
      public void MaintenanceRequestEqualsNegativeTest()
      {
         var request1 = new MaintenanceRequest
         {
            Description = "Bedroom door broken",
            Initiator = "Felice",
            Provider = "Housing LLC",
            DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
            Title = "Broken door",
            PropertyAddress = new Address { Address1 = "21 D st.", ApartmentNumber = "2A", City = "Reston", State = "VA", ZipCode = "12345" }
         };

         var request2 = new MaintenanceRequest
         {
            Description = "Bedroom door Will not close",
            Initiator = "Felice",
            Provider = "Housing LLC",
            DateSubmitted = DateTime.Parse("7/16/2017 10:00"),
            Title = "Broken door",
            PropertyAddress = new Address { Address1 = "21 D st.", ApartmentNumber = "2D", City = "Reston", State = "VA", ZipCode = "12345" }
         };

         Assert.IsFalse(request1.Equals(request2));
      }

   }
}
