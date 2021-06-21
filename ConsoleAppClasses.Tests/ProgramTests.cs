using System;
using Xunit;
using ConsoleAppClasses;

namespace ConsoleAppClasses.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void GoffieDoubleMath()
        {
            double num1 = 99;
            double num2 = 0;


            double result = Program.DivMath(num1, num2);

            Assert.True(Double.IsInfinity(result));
        }

        [Fact]
        public void PrecisionDoubleMath()
        {
            double num1 = 1;
            double num2 = 3;
            double expected = 0.333;

            double result = Program.DivMath(num1, num2);

            Assert.Equal(expected, result, 3);
        }
    }
}
