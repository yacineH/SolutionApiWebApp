﻿using System;
using System.Linq;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;
using ApiWebApp.Controllers;

namespace TestApiWebApp
{
    public class WeatherForCastControllerTests
    {

        private Mock<ILogger<WeatherForecastController>> loggerStub=new Mock<ILogger<WeatherForecastController>>();

        [Fact]
        public void Get_NoArguments_ReturnsDefaultForeCastDays()
        {
            var controller = new WeatherForecastController(loggerStub.Object);

            var expectedDays = 7;

            var foreCasts = controller.Get();
            Assert.NotNull(foreCasts);
            Assert.Equal(expectedDays, foreCasts.Count());

        }
    }
}
