using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnMyName()
        {
             var returnValue = controller.Get(1);
             Assert.Equal("Santosh", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
