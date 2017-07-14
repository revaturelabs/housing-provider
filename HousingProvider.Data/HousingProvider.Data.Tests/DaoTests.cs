using HousingProvider.Data.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HousingProvider.Data.Library.Models;
using HousingProvider.Data.Library.DAOModels;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class DaoTests
    {

        [Test]
        public void TestAddPerson()
        {
            //Set Up
            var h = new DaoHandler();
            var Person = new Person() { FirstName = "Yolanda", LastName = "Molina", ContactId = 1, ProviderId = 1, RoleId = 1 };

            //Result
            bool result = h.PersonDao.Add(Person); 

            //Expectation
            bool expected = true;

            Assert.IsTrue(result == expected);
        }

        [Test]
        public void GetPersonByFullName()
        {
            //Set Up
            var h = new DaoHandler();

            //Result
            int result = -1;

            //Expectation
            int expected = 0;

            Assert.IsTrue(result > expected);
        }

        [Test]
        public void DeletePersonById()
        {
            //Set Up
            var h = new DaoHandler();

            //Result
            int result = -1;

            //Expectation
            int expected = 0;

            Assert.IsTrue(result > expected);
        }

        [Test]
        public void DeletePerson()
        {
            //Set Up
            var h = new DaoHandler();

            //Result
            int result = -1;

            //Expectation
            int expected = 0;

            Assert.IsTrue(result > expected);
        }




    }
}
