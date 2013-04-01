using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern00.Strategy.Behaviour
{
	public interface ITriathlonDetails : IEventDetails
	{
		double SwimDistanceInKm { get; set; }
		double CycleDistanceInKm { get; set; }
		double RunDistanceInKm { get; set; }
	}
}
