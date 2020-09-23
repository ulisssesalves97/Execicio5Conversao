
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Exercicio5Conversao
{
	public static class ConvertTemperature
	{
		public static float KelvinToCent(float value)
		{
			return value - 273f;
		}

		public static float CentToKelvin(float value)
		{
			return value + 273f;
		}
	}
}
