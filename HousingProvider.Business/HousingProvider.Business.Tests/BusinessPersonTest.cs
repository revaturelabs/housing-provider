using HousingProvider.Business.Library.Models;
using NUnit.Framework;

namespace HousingProvider.Business.Tests
{
   [TestFixture]
    public class BusinessPersonTest
    {
        [Test]
        public void GetFullNameTest()
        {
            var person = new Person { FirstName = "Omar", LastName = "Reid" };
            var actual = person.GetFullName();

            Assert.IsTrue(actual == "Omar Reid");
        }
        
        [Test]
        public void EqualsPositiveTest()
        {
            var person1 = new Person { FirstName = "Carl", LastName = "Paul" };
            var person2 = new Person { FirstName = "Carl", LastName = "Carr" };
            var person3 = new Person { FirstName = "Carl", LastName = "Carr" };

            //Assert.IsTrue(person1.Equals(person2));

            //Assert.IsFalse(person1.Equals(person2));

            Assert.IsTrue(person2.Equals(person3));
        }

        [Test]
        public void EqualsNegativeTest()
        {
            var person1 = new Person { FirstName = "Carl", LastName = "Paul" };
            var person2 = new Person { FirstName = "Carl", LastName = "Carr" };
            var person3 = new Person { FirstName = "Carl", LastName = "Carr" };

            Assert.IsFalse(person1.Equals(person2));
        }
    }
}
