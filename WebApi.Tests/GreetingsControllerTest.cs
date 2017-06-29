using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;
using System.Web.Http.Results;

namespace WebApi.Tests.Controllers
{
    [TestClass]
    public class GreetingsControllerTest
    {
        [TestMethod]
        public void TestGreet()
        {
            // Arrange
            GreetingsController controller = new GreetingsController();

            // Act
            var result = controller.Greet() as OkNegotiatedContentResult<string>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Content);
            Assert.AreEqual("Hello, world!", result.Content);
        }
    }
}
