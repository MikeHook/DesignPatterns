using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pattern00.Strategy.Behaviour;

namespace Pattern00.Strategy.Core
{
	public abstract class Event
	{
		public IEventDetails EventDetails { get; set; }

		public Event(IEventDetails eventDetails)
		{
			EventDetails = eventDetails;
		}		

		public void DisplayEventDetails()
		{
			EventDetails.DisplayEventDetails();
			Console.WriteLine("Finish the race");
			Console.WriteLine("");

		}
	}
}
