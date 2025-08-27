using Xunit;
using TemperatureApp;

namespace TemperatureTests
{
    public class TempConverterTests
    {
        [Fact]
        public void CelsiusToFahrenheit_BoilingPoint_Works()
        {
            var converter = new TempConverter();
            converter.SetCelsius(100);
            Assert.Equal(212, converter.GetFahrenheit(), precision: 1);
        }

        [Fact]
        public void FahrenheitToCelsius_FreezingPoint_Works()
        {
            var converter = new TempConverter();
            converter.SetFahrenheit(32);
            Assert.Equal(0, converter.GetCelsius(), precision: 1);
        }

        [Fact]
        public void RoundTrip_Celsius_Fahrenheit_Celsius_PreservesValue()
        {
            var converter = new TempConverter();
            converter.SetCelsius(25);
            double f = converter.GetFahrenheit();
            converter.SetFahrenheit(f);
            Assert.Equal(25, converter.GetCelsius(), precision: 1);
        }

        [Theory]
        [InlineData(-40, -40)]
        [InlineData(0, 32)]
        [InlineData(37, 98.6)]
        public void KnownPairs_CelsiusToFahrenheit(double c, double expectedF)
        {
            var converter = new TempConverter();
            converter.SetCelsius(c);
            Assert.Equal(expectedF, converter.GetFahrenheit(), precision: 1);
        }
    }
}
