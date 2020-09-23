using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Exercicio5Conversao.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ConvertTemperatureController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<ConvertTemperatureController> _logger;

		public ConvertTemperatureController(ILogger<ConvertTemperatureController> logger)
		{
			_logger = logger;
		}

		[HttpGet("c2k/{val}")]
		public string GetCelsiusToKelvin(float val)
		{
			return string.Format("{0} ºC são {1} K", val, ConvertTemperature.CelsiusToKelvin(val));
		}

		[HttpGet("k2c/{val}")]
		public string GetKelvinToCelsius(float val)
		{
			return string.Format("{0} K são {1} ºC", val, ConvertTemperature.KelvinToCelsius(val));
		}

		[HttpGet("c2f/{val}")]
		public string GetCelsiusToFahren(float val)
		{
			return string.Format("{0} ºC são {1} ºF", val, ConvertTemperature.CelsiusToFahren(val));
		}

		[HttpGet("f2c/{val}")]
		public string GetFahrenToCelsius(float val)
		{
			return string.Format("{0} ºF são {1} ºC", val, ConvertTemperature.FahrenToCelsius(val));
		}

		[HttpGet("f2k/{val}")]
		public string GetFahrenToKelvin(float val)
		{
			return string.Format("{0} ºC são {1} K", val, ConvertTemperature.FahrenToKelvin(val));
		}

		[HttpGet("k2f/{val}")]
		public string GetKelvinToFahren(float val)
		{
			return string.Format("{0} K são {1} ºF", val, ConvertTemperature.KelvinToFahren(val));
		}
	}
}
