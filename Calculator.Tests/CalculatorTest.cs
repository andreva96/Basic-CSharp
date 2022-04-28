using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1,2);
            Assert.Equal(3,result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.55);
            Assert.Equal(4.78, result, 1); // expected, actual, precision
        }
    }
}