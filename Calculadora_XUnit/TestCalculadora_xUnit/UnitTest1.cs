using Xunit;

public class TestCalculadora
{
    [Fact]
    public void TestSumarPositivos()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        // Act
        int resultado = calculadora.Sumar(3, 5);
        // Assert
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestSumarNegativos()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        // Act
        int resultado = calculadora.Sumar(-2, -4);
        // Assert
        Assert.Equal(-6, resultado);
    }

    [Fact]
    public void TestSumarMezclados()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        // Act
        int resultado = calculadora.Sumar(10, -7);
        // Assert
        Assert.Equal(3, resultado);
    }
}