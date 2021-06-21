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
            Car testCar;

            //Act
            testCar = new Car(brand, model, color, year, hp);

            //Assert

        }
    }
}
