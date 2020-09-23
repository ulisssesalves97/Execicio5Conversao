
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Exercicio5Conversao
{
	public static class ConvertTemperature
	{
		public static float KelvinToCelsius(float value)
		{
			return value - 273f;
		}

		public static float CelsiusToKelvin(float value)
		{
			return value + 273f;
		}

		public static float FahrenToCelsius(float value)
		{
			return (value - 32f) / 1.8f;
		}

		public static float CelsiusToFahren(float value)
		{
			return (1.8f * value) + 32f;
		}

		public static float FahrenToKelvin(float value)
		{
			return (value - 32f) * 0.555556f + 273f;
		}

		public static float KelvinToFahren(float value)
		{
			return (value - 273f) * 1.8f + 32f;
		}

	}
}
