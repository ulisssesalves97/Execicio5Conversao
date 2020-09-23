using Exercicio5Conversao;
using System;
using Xunit;

namespace Execicio5Conversao.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidCentToKelvin()
        {
            Assert.Equal(453f, ConvertTemperature.CentToKelvin(180f));
        }
        [Fact]
        public void ValidKelvinToCent()
        {
            Assert.Equal(180f, ConvertTemperature.KelvinToCent(453f));
        }
    }
}
