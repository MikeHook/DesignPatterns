using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pattern00.Strategy.Core;

namespace Pattern00.Strategy.Behaviour
{
	public class DuathlonDetails : IDuathlonDetails
	{
		public DuathlonDetails(double runLeg1DistanceInKm, double cycleDistanceInKm, double runLeg2DistanceInKm)
		{
			RunLeg1DistanceInKm = runLeg1DistanceInKm;
			CycleDistanceInKm = cycleDistanceInKm;
			RunLeg2DistanceInKm = runLeg2DistanceInKm;
		}

		public string EventName { get; set; }
		public double RunLeg1DistanceInKm { get; set; }
		public double CycleDistanceInKm { get; set; }
		public double RunLeg2DistanceInKm { get; set; }

		public void DisplayEventDetails()
		{
			Console.WriteLine(string.Format("Start the {0} Duathlon", EventName));
			Console.WriteLine(string.Format("Run for {0}km", RunLeg1DistanceInKm));
			Console.WriteLine(string.Format("Cycle for {0}km", CycleDistanceInKm));
			Console.WriteLine(string.Format("Run for {0}km", RunLeg2DistanceInKm));
		}
	}
}
