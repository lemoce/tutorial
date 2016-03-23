using System;

namespace events
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Thermostat t = new Thermostat ();
			Heater h = new Heater (10);
			Cooler c = new Cooler (24);

			Random r = new Random ();

			t.OnTemperatureChange += h.OnTemperatureChange;
			t.OnTemperatureChange += c.OnTemperatureChange;

			for (int i = 0; i < 10; i++) {
				t.CurrentTemperature = (float) (40 * r.NextDouble ());
				Console.WriteLine ($"{ i } -> { t.CurrentTemperature }C");
			}

		}
	}

	public class Thermostat
	{
		public Action<float> OnTemperatureChange { get; set; }

		public float CurrentTemperature { 
			get { return _CurrentTemperature; }
			set {
				if (value != CurrentTemperature) {
					_CurrentTemperature = value;

					OnTemperatureChange?.Invoke (value);
					//OnTemperatureChange (value);
				}
			}
		}
		private float _CurrentTemperature;

	}
}
