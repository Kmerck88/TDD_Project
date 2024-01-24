using Xunit;
using FirstTest;

namespace FirstTest.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(5, 7, 12)]
        [InlineData(3, 4, 7)]
        [InlineData(-2, 2, 0)]
        [InlineData(0, 0, 0)]
        public void CalculateSumReturnsCorrectSum(int firstNumber, int secondNumber, int expectedSum)
        {
            // Act
            int actualSum = Program.CalculateSum(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}
