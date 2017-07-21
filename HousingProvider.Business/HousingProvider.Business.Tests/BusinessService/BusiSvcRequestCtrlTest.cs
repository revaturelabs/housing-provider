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
    public void PostTest() 
    {
      var r = new Request();
      var request = new ServiceController();
      var controller = request.Post(r);
      
      Console.WriteLine(controller);
      
      Assert.True(controller);
    }

    [Test]
    //[AsyncStateMachine(typeof(Task))]
    public void GetTest()
    {
      var r = new Complex();
      var request = new ServiceController();
      //var controller = request.Get(r);

      Console.WriteLine(request.Get(r));
      //Assert.IsNotNull(controller);
    }
  }
}
