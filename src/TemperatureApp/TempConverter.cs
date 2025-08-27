namespace TemperatureApp
{
    /// <summary>
    /// Encapsulated temperature converter.
    /// Stores Celsius internally and provides conversion methods.
    /// </summary>
    public class TempConverter
    {
        private double celsius;

        public TempConverter(double c = 0.0)
        {
            celsius = c;
        }

        /// <summary>Sets temperature in Celsius.</summary>
        public void SetCelsius(double c)
        {
            celsius = c;
        }

        /// <summary>Gets temperature in Celsius.</summary>
        public double GetCelsius()
        {
            return celsius;
        }

        /// <summary>Sets temperature in Fahrenheit (internally converted to Celsius).</summary>
        public void SetFahrenheit(double f)
        {
            celsius = (f - 32) * 5.0 / 9.0;
        }

        /// <summary>Gets temperature in Fahrenheit.</summary>
        public double GetFahrenheit()
        {
            return (celsius * 9.0 / 5.0) + 32;
        }
    }
}
