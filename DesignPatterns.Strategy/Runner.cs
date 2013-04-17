using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
	public class Runner : EventAttendee
	{
		public Runner(string name, ICompeteBehaviour competeBehaviour)
			: base(name, competeBehaviour)
		{ }

		public override string Render()
		{
			return string.Format("I am a runner, my name is {0}", Name);
		}
	}
}
