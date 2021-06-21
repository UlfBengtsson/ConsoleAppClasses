using System;
using Xunit;
using ConsoleAppClasses;

namespace ConsoleAppClasses.Tests
{
    public class CarTests
    {
        /*
         * 1. Constructor sets all relevant data right
         * 2. Model prop prevents null empty whitespace
         * 3. All info in string from Info method
         */


        [Fact]
        public void Constructor()
        {
            //Arrange
            string brand = "Saab";
            string model = "9-5";
            string color = "blue";
            int year = 1987;
            int hp = 210;
            Car testCar = null;

            //Act
            testCar = new Car(brand, model, color, year, hp);

            //Assert
            Assert.NotNull(testCar);
            Assert.Equal(brand, testCar.brand);
            Assert.Equal(model, testCar.Model);
            Assert.Equal(color, testCar.color);
            Assert.Equal(year, testCar.year);
            Assert.Equal(hp, testCar.hp);
        }

        [Theory]
        [InlineData("900")]
        [InlineData("900S")]
        [InlineData("9-5")]
        [InlineData("9-X")]
        [InlineData("Kadett")]
        [InlineData("X3")]
        [InlineData("Diablo")]
        [InlineData("Model 3")]
        public void ModelPropValidInputs(string modelInput)
        {
            //Arrange
            string brand = "Saab";
            string color = "blue";
            int year = 1987;
            int hp = 210;
            Car testCar = null;

            //Act
            testCar = new Car(brand, modelInput, color, year, hp);

            //Assert
            Assert.Equal(modelInput, testCar.Model);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]

        public void ModelPropBadInputs(string modelInput)
        {
            //Arrange
            string brand = "Saab";
            string color = "blue";
            int year = 1987;
            int hp = 210;

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(
                () => new Car(brand, modelInput, color, year, hp));

            //Assert
            Assert.Equal("Model cant be empty.", result.Message);
        }
    }
}
