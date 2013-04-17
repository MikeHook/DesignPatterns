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
			EventAttendees = new List<EventAttendee>();
		}

		public string Name { get; set; }
		public List<EventAttendee> EventAttendees { get; set; }

		public IEnumerable<string> RenderAttendees()
		{
			return EventAttendees.Select(a => a.Render());			
		}

		public IEnumerable<string> ConductEvent()
		{
			var results = new List<string>();
			EventAttendees.ForEach(a => a.Compete(results));
			return results;
		}
	}
}
