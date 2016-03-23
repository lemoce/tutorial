using System;

namespace events
{
	public class Cooler
	{
		public Cooler (float temperature)
		{
			Temperature = temperature;
		}

		public float Temperature { get; set; }

		public void OnTemperatureChange(float newTemperature)
		{
			if (newTemperature > Temperature) {
				Console.WriteLine ("Cooler: On");
			} else {
				Console.WriteLine ("Cooler: Off");
			}
		}
	}

	public class Heater
	{
		public Heater (float temperature)
		{
			Temperature = temperature;
		}

		public float Temperature { get; set; }

		public void OnTemperatureChange(float newTemperature)
		{
			if (newTemperature < Temperature) {
				Console.WriteLine ("Heater: On");
			} else {
				Console.WriteLine ("Heater: Off");
			}
		}
	}

}

