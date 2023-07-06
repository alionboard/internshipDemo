using InternshipDemo.Controllers;

namespace InternshipDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var controller = new WeatherForecastController();

        //Act
        var result = controller.Get();

        //Assert
        Assert.NotNull(result);
    }
}