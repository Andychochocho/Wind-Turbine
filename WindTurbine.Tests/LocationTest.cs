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

        [Fact]
        public void GetLatitudeTest()
        {
            //Arrange
            var location = new Location();

            //Act
            location.Latitude = "123";
            var result = location.Latitude;

            //Assert
            Assert.Equal("123", result);
        }

        [Fact]
        public void GetLongitudeTest()
        {
            //Arrange
            var location = new Location();

            //Act
            location.Longitude = "321";
            var result = location.Longitude;

            //Assert
            Assert.Equal("321", result);
        }
    }
}