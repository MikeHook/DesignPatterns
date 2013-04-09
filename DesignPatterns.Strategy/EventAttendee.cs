using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
	public abstract class EventAttendee
	{
		public EventAttendee(string name, ICompeteBehaviour competeBehaviour)
		{
			Name = name;
			CompeteBehaviour = competeBehaviour;
		}

		public string Name { get; set; }
		public ICompeteBehaviour CompeteBehaviour { get; set; }

		public abstract string Render();


		public void Compete(IList<string> results)
		{
			CompeteBehaviour.Compete(Name, results);
		}
	}
}
