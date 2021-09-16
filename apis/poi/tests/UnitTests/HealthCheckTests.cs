using System;
using Xunit;
using poi.Models;

namespace UnitTests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            //Comment
            Assert.Equal("POI Service Healthcheck", new Healthcheck().Message);
            Assert.Equal("Still Healthy", new Healthcheck().Status);

        }
    }
}
