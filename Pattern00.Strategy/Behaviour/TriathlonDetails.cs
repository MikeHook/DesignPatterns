using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern00.Strategy.Behaviour
{
	public class TriathlonDetails : ITriathlonDetails
	{
		public TriathlonDetails(double swimDistanceInKm, double cycleDistanceInKm, double runDistanceInKm)
		{
			SwimDistanceInKm = swimDistanceInKm;
			CycleDistanceInKm = cycleDistanceInKm;
			RunDistanceInKm = runDistanceInKm;
		}

		public string EventName { get; set; }
		public double SwimDistanceInKm { get; set; }
		public double CycleDistanceInKm { get; set; }
		public double RunDistanceInKm { get; set; }

		public void DisplayEventDetails()
		{
			Console.WriteLine(string.Format("Start the {0} Triathlon", EventName));
			Console.WriteLine(string.Format("Swim for {0}km", SwimDistanceInKm));
			Console.WriteLine(string.Format("Cycle for {0}km", CycleDistanceInKm));
			Console.WriteLine(string.Format("Run for {0}km", RunDistanceInKm));
		}

	}
}
