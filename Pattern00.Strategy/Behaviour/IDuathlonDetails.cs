using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern00.Strategy.Behaviour
{
	public interface IDuathlonDetails : IEventDetails
	{
		double RunLeg1DistanceInKm { get; set; }
		double CycleDistanceInKm { get; set; }
		double RunLeg2DistanceInKm { get; set; }		
	}
}
