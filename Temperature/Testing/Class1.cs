using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Temperature;

namespace Testing
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [SetUp]
        public void SetUp()
        {
            _converter = new TemperatureConverter();
        }

        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(-40, -40)]
        public void CelsiusToFahrenheit_ShouldConvertCorrectly(double celsius, double expected)
        {
            Assert.That(_converter.CelsiusToFahrenheit(celsius), Is.EqualTo(expected).Within(0.1));
        }

        [TestCase(32, 0)]
        [TestCase(212, 100)]
        [TestCase(-40, -40)]
        public void FahrenheitToCelsius_ShouldConvertCorrectly(double fahrenheit, double expected)
        {
            Assert.That(_converter.FahrenheitToCelsius(fahrenheit), Is.EqualTo(expected).Within(0.1));
        }
    }
}
