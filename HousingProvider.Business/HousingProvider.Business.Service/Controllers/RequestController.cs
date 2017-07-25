using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingProvider.Business.Library.Models;
using HousingProvider.Business.Service.DataModels;

using Newtonsoft.Json;
using System.Net.Http;
using HousingProvider.Business.Library.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingProvider.Business.Service.Controllers
{
  [Route("api/[controller]")]
  public class RequestController : DataSvcController
  {
    public RequestController()
    {
      DataSvcUrl += "request";
    }

    [HttpPost]
    public bool Post([FromBody]Request req)
    {
      return DataFactory<Request>.Access(DataSvcUrl).Create(req);
    }

    [HttpPost]
    public List<Request> Get()
    {
      var r1 = new Request();
      var request = new List<Request>();

      //var r1 = new Request();

      request.Add(new Request()
      {
        
        Description = "Sink Leak",
        Status = StatusEnum.PENDING,
        Title = "Bathroom",
        Urgent = true,
        DateSubmitted = DateTime.Now
      });

      request.Add(new Request()
      {
        Description = "Blows hot air",
        Status = StatusEnum.INWORK,
        Title = "Air Conditioning",
        Urgent = true,
        DateSubmitted = DateTime.Now
      });

      request.Add(new Request()
      {
        Description = "Tissue",
        Status = StatusEnum.REJECTED,
        Title = "Bathroom",
        Urgent = true,
        DateSubmitted = DateTime.Now
      });

      request.Add(new Request()
      {
        Description = "Kitchen",
        Status = StatusEnum.INWORK,
        Title = "Paper Towels",
        Urgent = false,
        DateModified = DateTime.Now
      });

      request.Add(new Request()
      {
        Description = "Kitchen",
        Status = StatusEnum.PENDING,
        Title = "Broken Microwave",
        Urgent = true,
        DateSubmitted = DateTime.Now
      });

      return request;

    }
  }
}