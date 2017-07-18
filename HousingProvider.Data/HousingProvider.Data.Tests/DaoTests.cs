//using HousingProvider.Data.Library;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using HousingProvider.Data.Library.EFModels;
//using HousingProvider.Data.Library.DAO;

//namespace HousingProvider.Data.Tests
//{
//    [TestFixture]
//    public class DaoTests
//    {
//        // :)

//        [Test]
//        public void TestAddPerson()
//        {
//            //Set Up
//            var h = new DaoHandler();
//            var Person = new Person() { FirstName = "Yolanda", LastName = "Molina", ContactId = 1, ProviderId = 1, RoleId = 1 };

//            //Result
//            bool result = h.PersonDao.Add(Person); 

//            //Expectation
//            bool expected = true;

//            Assert.IsTrue(result == expected);
//        }

//        [Test]
//        public void GetPersonByFullName()
//        {
//            //Set Up
//            var h = new DaoHandler();
//            string fn = "Yolanda Molina";

//            //Result
//            Person result = h.PersonDao.Get(fn);

//            //Output
//            Console.WriteLine($"{result.PersonId} + {result.FirstName} + {result.LastName}" );

//            //Expectation
//            // person

//            Assert.IsTrue(result != null);
//        }

//        [Test]
//        public void DeletePersonById()
//        {
//            //Set Up
//            var h = new DaoHandler();
//            int id = 3;

//            //Result
//            bool result = h.PersonDao.DeleteById(id);

//            //Expectation
//            bool expected = true;

//            Assert.IsTrue(result == expected);
//        }

//        [Test]
//        public void DeletePersonByObject()
//        {
//            //Set Up
//            var h = new DaoHandler();
//            string fn = "Yolanda Molina";
//            Person PersonToBeDeleted = h.PersonDao.Get(fn);


//            //Result
//            bool result = h.PersonDao.Delete(PersonToBeDeleted);

//            //Expectation
//            bool expected = true;

//            Assert.IsTrue(result == expected);
//        }


//        [Test]
//        public void UpdateContact()
//        {
//            //Set Up
//            var h = new DaoHandler();
//            //Contact NewContactInfo = new Contact() { ContactId = 2, Active = true, Email = "real@email.com", Phone = "407-993-9999" };
//            Contact nc = h.ContactDao.Get("second@email.com");
//            nc.Email = "real@email.com";
//            nc.Phone = "407-993-9999";

//            //Result
//            bool result = h.ContactDao.Update(nc);

//            //Expectation
//            bool expected = true;

//            Assert.IsTrue(result == expected);
//        }

//    }
//}
