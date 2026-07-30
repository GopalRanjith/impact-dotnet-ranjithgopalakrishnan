
using Xunit; using CSharpLearning;
public class TemperatureConverterTests{
[Fact] public void CelsiusToFahrenheit(){Assert.Equal(32,TemperatureConverter.CelsiusToFahrenheit(0));}
[Fact] public void FahrenheitToCelsius(){Assert.Equal(100,TemperatureConverter.FahrenheitToCelsius(212));}
[Fact] public void KelvinToCelsius(){Assert.Equal(0,TemperatureConverter.KelvinToCelsius(273.15),5);}
}
