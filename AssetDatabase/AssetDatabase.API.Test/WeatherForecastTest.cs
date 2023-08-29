using Xunit;

namespace AssetDatabase.API.Test;

public class WeatherForecastTest
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void CelsiusToFahrenheitTheory(int celsius, int fahrenheit)
    {
        var forecastModel = new WeatherForecast()
        {
            TemperatureC = celsius,
        };
        
        Assert.Equal(fahrenheit, forecastModel.TemperatureF);
    }
}
