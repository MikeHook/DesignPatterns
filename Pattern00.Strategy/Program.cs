using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pattern00.Strategy.Core;
using Pattern00.Strategy.Behaviour;

namespace Pattern00.Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("This is a demo implementing the Strategy pattern");
			Console.WriteLine("Define a family of algorithms (behaviour), encapsulate each one and make them interchangeable.");
			Console.WriteLine("AKA: Separate what changes (the behaviour) from what does not.");
			Console.WriteLine("");

			var triathlonDetails = new TriathlonDetails(0.5, 25.0, 5.0);
			triathlonDetails.EventName = "Dorney Lake";
			var sportsEvent = new Triathlon(triathlonDetails);
			sportsEvent.DisplayEventDetails();

			var duathlonDetails = new DuathlonDetails(5.0, 25.0, 5.0);
			duathlonDetails.EventName = "London";
			var duathlete = new Duathlon(duathlonDetails);
			duathlete.DisplayEventDetails();

		}
	}
}
