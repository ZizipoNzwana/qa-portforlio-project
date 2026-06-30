namespace UnitTests;

public class Tests
{
    [Test]
    public void Add_TwoAndThree_ReturnsFive()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 2;
        int b = 3;
        int expected = 5;

        // Act
        int actual = calculator.Add(a, b);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]

    public void SubstractingTenAndEight_ReturnsTwo()
    {

        var calculator = new Calculator();
        int a = 10;
        int b =  2;

        int expected = 8;

        int result = calculator.Subtract(a, b);
        
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void multiply()
    {
        var calculator = new Calculator();
        int a = 2;
        int b = 4;

        int expected = 8;

        int result = calculator.Multiplication(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void divide()
    {
        var calculator = new Calculator();

        int a = 10;
        int b = 2;

        int expected = 5;

        int result = calculator.Division(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }
}