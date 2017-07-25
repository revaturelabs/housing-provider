using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Net.Http;
using HousingProvider.Business.Library.Models;
using Newtonsoft.Json;
using HousingProvider.Business.Service.Controllers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HousingProvider.Business.Library.Interfaces;
using HousingProvider.Business.Service.DataModels;


namespace HousingProvider.Business.Tests.BusinessService
{
  [TestFixture]
  public class BusiSvcRequestCtrlTest
  {


    [Test]
    //[AsyncStateMachine(typeof(Task))]
    public void GetComplexTest()
    {
      var request = new ComplexController();
      var controller = request.Get();

      

      Assert.IsNotNull(controller);
    }

    [Test]
    //[AsyncStateMachine(typeof(Task))]
    public void PostRequestTest()
    {
      var r = new Request();
      var request = new RequestController();
      var controller = request.Post(r);

     

      Assert.IsTrue(controller);
    }

    [Test]
    //[AsyncStateMachine(typeof(Task))]
    public void GetRequestTest()
    {
      var r = new Request();
      var request = new RequestController();
      var controller = request.Get();

      Assert.IsNotNull(controller);
    }

  }
}