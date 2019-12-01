using NUnit.Framework;
using Brewery.MVC.Controllers;
using Moq;
using Brewery.MVC;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Brewery.UnitTests
{
  public class Tests
  {
    private Mock<IBreweryDataAccess> _mockedDataAccess;
    private Mock<ILogger<BreweryAPIController>> _mockedLogger;
    private BreweryAPIController _controller;

    [SetUp]
    public void Setup()
    {
      _mockedDataAccess = new Mock<IBreweryDataAccess>(MockBehavior.Strict);
      _mockedLogger = new Mock<ILogger<BreweryAPIController>>(MockBehavior.Strict);
      _controller = new BreweryAPIController(_mockedLogger.Object, _mockedDataAccess.Object);
    }

    [TearDown]
    public void TearDown()
    {
      _mockedDataAccess.VerifyAll();
      _mockedLogger.VerifyAll();
    }

    // These tests can be run using dotnet test

    [Test]
    public void Test_GetAll()
    {
      var breweries = new List<Brewery.Shared.Brewery>();

      _mockedDataAccess.Setup(x => x.GetAllBreweries()).Returns(breweries);
      // uncomment the next line, run the test, read the exception message.
      // mockedDataAccess.Setup(x => x.GetAllBreweriesFull()).Returns(breweries);

      var result = _controller.GetAllBreweries();

      // uncomment this obviously wrong line, see what happens
      // Assert.IsInstanceOf(typeof(NotFoundResult), result);

      Assert.IsInstanceOf(typeof(OkObjectResult), result);
      Assert.AreEqual(((OkObjectResult)result).Value, breweries);

    }

    [Test]
    public void Test_GetOneHappyFlow()
    {
      var brewery = new Brewery.Shared.Brewery()
      {
        Name = "abc"
      };
      _mockedDataAccess.Setup(x => x.GetBreweryById(12)).Returns(brewery);

      var result = _controller.GetBrewery(12);

      Assert.IsInstanceOf(typeof(OkObjectResult), result);
      Assert.AreEqual(((OkObjectResult)result).Value, brewery);
    }

    [Test]
    public void Test_GetOneNotFound()
    {
      _mockedDataAccess.Setup(x => x.GetBreweryById(13)).Returns(default(Brewery.Shared.Brewery));

      var result = _controller.GetBrewery(13);

      Assert.IsInstanceOf(typeof(NotFoundResult), result);
    }
  }
}