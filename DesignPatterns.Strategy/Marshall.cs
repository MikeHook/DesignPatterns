using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
	public class Marshall : EventAttendee
	{
		public Marshall(string name, ICompeteBehaviour competeBehaviour)
			: base(name, competeBehaviour)
		{ }

		public override string Render()
		{
			return string.Format("I am a marshall, my name is {0}", Name);
		}
	}
}
