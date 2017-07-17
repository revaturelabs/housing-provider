using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Net.Http;
using HousingProvider.Business.Library.Models;
using Newtonsoft.Json;

namespace HousingProvider.Business.Tests.BusinessService
{
    [TestFixture]
    public class BusiSvcRequestCtrlTest
    {
        private static string url = "http://localhost:58072/api/";
        private static HttpClient client = new HttpClient { BaseAddress = new Uri (url) };

        [Test]
        public async void GetAllTest()
        {
            var actual = new List<Request> ();
            var expected = 0;

            try
            {
                var response = await client.GetAsync ("request", HttpCompletionOption.ResponseContentRead);

                if (response.IsSuccessStatusCode)
                {
                    actual = JsonConvert.DeserializeObject<List<Request>> (response.Content.ReadAsStringAsync ().Result);
                }
            }
            catch
            {

            }

            Assert.IsTrue (actual.Count > expected);
        }
    }
}
