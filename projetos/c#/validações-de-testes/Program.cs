using NUnit.Framework;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsDifferenceOfTwoNumbers()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = calculator.Subtract(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }
}

