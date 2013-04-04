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

		public List<string> RenderAttendees()
		{
			var attendees = new List<string>();
			foreach (var attendee in EventAttendees)
			{
				attendees.Add(attendee.Render());
			}
			return attendees;
		}
	}
}
