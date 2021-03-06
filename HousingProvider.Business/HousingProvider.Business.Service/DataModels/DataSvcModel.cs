﻿using HousingProvider.Business.Library.Interfaces;
using HousingProvider.Business.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HousingProvider.Business.Service.DataModels
{
    public class DataSvcModel<T> : IDataModel<T> where T : ILibraryModel
    {
        private HttpClient _Client;

        internal DataSvcModel(string url)
        {
            _Client = new HttpClient();
            _Client.BaseAddress = new Uri(url);
        }

        public Guid Create(T obj)
        {
            var json = JsonConvert.SerializeObject(obj);

            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = _Client.PostAsync(_Client.BaseAddress.AbsoluteUri, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Guid>(r);
            }
            throw new HttpRequestException();
        }

        public List<T> GetAll()
        {
            var response = _Client.GetAsync(_Client.BaseAddress.AbsoluteUri).Result;
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return null;
            }
        }

        public List<T> GetAllByGuid(Guid guid)
        {
            var response = _Client.GetAsync(_Client.BaseAddress.AbsoluteUri + "/" + guid.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return null;
            }
        }

        public T FindByGuid(Guid guid)
        {
            var response = _Client.GetAsync(_Client.BaseAddress.AbsoluteUri + "/" + guid.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
            throw new KeyNotFoundException("No object with the specified Guid was found");
        }
    }
}
