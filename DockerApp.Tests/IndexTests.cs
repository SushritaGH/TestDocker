using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using DockerApp.Controllers; // Replace with your actual namespace
namespace DockerApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsAViewResult_WithCorrectViewData()
        {
            // Arrange: create a mock logger
            var mockLogger = new Mock<ILogger<HomeController>>();

            // Inject mock into controller
            var controller = new HomeController(mockLogger.Object);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.Equal("Home Page", controller.ViewData["Title"]);
        }
    }
}
