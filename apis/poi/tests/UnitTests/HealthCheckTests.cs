using System;
using Xunit;
using poi.Models;

namespace tests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            //Comment
            Assert.Equal("POI Service Healthcheck", new Healthcheck().Message);
            Assert.Equal("Healthy", new Healthcheck().Status);

        }
    }
}
