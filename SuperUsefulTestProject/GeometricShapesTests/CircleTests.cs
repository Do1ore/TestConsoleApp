using SuperUsefulClassLibrary.Implementation;

namespace SuperUsefulTestProject.GeometricShapesTests;

public class CircleTests
{
    [Fact]
    public void SurfaceCalculation_WithValidParameter_ShouldReturnValidResult()
    {
        //Arrange
        var expectedResult = 50.265482457436691815402294132472;
        //Act
        var circle = new Circle(4);
        var actual = circle.CalculateArea();
        //Assert
        Assert.Equal(expectedResult, actual, 0.00000000000000000000000001);
    }

    [Fact]
    public void SurfaceCalculation_WithZero_ShouldReturnZero()
    {
        //Arrange
        var expectedResult = 0;
        //Act
        var circle = new Circle(0);
        var actual = circle.CalculateArea();
        //Assert
        Assert.Equal(expectedResult, actual, 0);
    }
}