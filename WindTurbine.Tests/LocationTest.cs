using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindTurbine.Models;
using Xunit;

namespace WindTurbine.Tests
{
    public class LocationTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var location = new Location();

            //Act
            location.Name = "Portland";
            var result = location.Name;

            //Assert
            Assert.Equal("Portland", result);
        }
    }
}