using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
	public abstract class EventAttendee
	{
		public EventAttendee(string name)
		{
			Name = name;
		}

		public string Name { get; set; }

		public abstract string Render();
		public abstract string Compete();	
	}
}
