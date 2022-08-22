using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double teperatureCelsius)
        {
            return (teperatureCelsius * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) * 5 / 9;
        }
    }
}
