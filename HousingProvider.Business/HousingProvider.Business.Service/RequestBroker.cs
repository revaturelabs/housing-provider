using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingProvider.Business.Service.Interface;
using HousingProvider.Business.Library.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace HousingProvider.Business.Service
{
    public class RequestBroker : ICrud<Request>
    {
        private static string url = "http://localhost:58058/api/";
        private static HttpClient client = new HttpClient {BaseAddress = new Uri(url) };

        public bool Create(Request obj)
        {
            throw new NotImplementedException ();
        }

        public bool Delete(Request obj)
        {
            throw new NotImplementedException ();

        }

        public async Task<List<Request>> Get()
        {
            var list = new List<Request> ();

            try
            {
                var response = await client.GetAsync ("request", HttpCompletionOption.ResponseContentRead);

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Request>> (response.Content.ReadAsStringAsync().Result);
                }
            }
            catch
            {

            }

            return list;
        }

        public bool Update(Request obj)
        {
            throw new NotImplementedException ();
        }
    }
}
