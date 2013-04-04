using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
	public class Event
	{
		public Event(string name)
		{
			Name = name;
		}

		public string Name { get; set; }
		public List<EventAttendee> EventAttendees { get; set; }
	}
}
