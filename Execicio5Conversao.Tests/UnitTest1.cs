using Exercicio5Conversao;
using System;
using Xunit;

namespace Execicio5Conversao.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidCelsiusToKelvin()
        {
            Assert.Equal(453f, ConvertTemperature.CelsiusToKelvin(180f));
        }
        [Fact]
        public void ValidKelvinToCelsius()
        {
            Assert.Equal(180f, ConvertTemperature.KelvinToCelsius(453f));
        }
        [Fact]
        public void ValidCelsiusToFahren()
        {
            Assert.Equal(50f, ConvertTemperature.CelsiusToFahren(10f));
        }
        [Fact]
        public void ValidFahrenToCelsius()
        {
            Assert.Equal(10f, ConvertTemperature.FahrenToCelsius(50f));
        }
        [Fact]
        public void ValidFahrenToKelvin()
        {
            Assert.Equal(273.15f, ConvertTemperature.FahrenToKelvin(32f));
        }
        [Fact]
        public void ValidKelvinToFahren()
        {
            Assert.Equal(212f, ConvertTemperature.KelvinToFahren(373f));
        }
    }
}
