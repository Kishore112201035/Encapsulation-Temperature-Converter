namespace TemperatureApp
{   /// Encapsulated temperature converter.
    public class TempConverter
    {
        private double celsius;
        public TempConverter(double c = 0.0)
        {
            celsius = c;
        }

        /// Sets temperature in Celsius
        public void SetCelsius(double c)
        {
            celsius = c;
        }
        /// Gets temperature in Celsius
        public double GetCelsius()
        {
            return celsius;
        }
        /// Sets temperature in Fahrenheit (internally converted to Celsius).
        public void SetFahrenheit(double f)
        {
            celsius = (f - 32) * 5.0 / 9.0;
        }
        /// Gets temperature in Fahrenheit.
        public double GetFahrenheit()
        {
            return (celsius * 9.0 / 5.0) + 32;
        }
    }
}
