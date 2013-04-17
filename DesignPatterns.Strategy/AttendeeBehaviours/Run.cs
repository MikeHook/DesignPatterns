using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy.AttendeeBehaviours
{
	public class Run : ICompeteBehaviour
	{
		public void Compete(string attendeeName, IList<string> results)
		{
			results.Add(string.Format("{0} ran in event", attendeeName));
		}
	}
}
