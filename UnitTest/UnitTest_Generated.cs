using System;
using Xunit;
using DemoUnitTest_ConsoleApp;
// Assuming the Calculator class is accessible (e.g., in the same namespace or referenced project)

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        int number1 = 5;
        int number2 = 3;
        int expectedResult = 8;

        // Act
        int actualResult = calculator.Add(number1, number2);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        int number1 = 10;
        int number2 = -4;
        int expectedResult = 6; // 10 + (-4) = 6

        // Act
        int actualResult = calculator.Add(number1, number2);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        int number1 = -5;
        int number2 = -10;
        int expectedResult = -15; // -5 + (-10) = -15

        // Act
        int actualResult = calculator.Add(number1, number2);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}