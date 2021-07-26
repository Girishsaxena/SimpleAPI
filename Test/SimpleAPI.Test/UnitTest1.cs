using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        // Arrange
        WeatherForecastController we = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            //Act
            var output = we.FetchData(1);
            //assert
            Assert.Equal("Girish Saxen",output);
        }
    }
}
