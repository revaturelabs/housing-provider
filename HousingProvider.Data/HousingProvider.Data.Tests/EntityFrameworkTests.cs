using HousingProvider.Data.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HousingProvider.Data.Tests
{
    [TestFixture]
    public class EntityFrameworkTests
    {

        [Test]
        public void TestContext()
        {
            var myContext = ContextFactory.GetContext();

            var request = myContext.Request.First();
            Console.WriteLine(request.Description);

            var result = myContext.Request.ToList().Count;


            int expected = 0;

            Assert.IsTrue(result > expected);
        }
    }
}
