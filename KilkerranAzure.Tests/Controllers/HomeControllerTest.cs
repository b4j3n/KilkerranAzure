using System.Web.Mvc;

using KilkerranAzure.Controllers;

using NUnit.Framework;

namespace KilkerranAzure.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult viewResult = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(viewResult);
        }

        [Test]
        public void DummyTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult viewResult = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Hello from Home in Azure.", viewResult.ViewBag.Message);
        }
    }
}
