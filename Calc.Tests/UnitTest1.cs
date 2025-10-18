using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Calc.Tests
{
    public class AllTests
    {
        [Fact]
        public void Sum_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Program.sum(2, 3); // استدعاء الدالة sum
            Assert.Equal(5, result);
        }

        [Fact]
        public void Sum_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            int result = Program.sum(5, -3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Sum_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = Program.sum(-4, -6);
            Assert.Equal(-10, result);
        }


        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            int result = Program.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_PositiveAndNegativeNumber_ReturnsCorrectProduct()
        {
            int result = Program.Multiply(5, -3);
            Assert.Equal(-15, result);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            int result = Program.Multiply(7, 0);
            Assert.Equal(0, result);
        }
    }
}