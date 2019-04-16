using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArkanoTest.Service.Computer;
using ArkanoTest.Service.Computer.Controllers;
using ArkanoTest.Service.Computer.Repository;
using System.Web.Http.Results;
using ArkanoTest.Service.Computer.Repository.Ram;
using ArkanoTest.Service.Computer.Data;

namespace ArkanoTest.Service.Computer.Tests.Controllers
{
    [TestClass]
    public class RamsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            RamsController controller = new RamsController(new RamMockRepository());

            // Act
            var result = controller.GetRams().Result;
            // Assert
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<List<RAM>>));
        }
    }
}
