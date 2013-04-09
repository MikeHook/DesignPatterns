using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy.AttendeeBehaviours
{
	public class CompeteInTri : ICompeteBehaviour
	{
		public void Compete(string attendeeName, IList<string> results)
		{
			results.Add(string.Format("{0} ran, cycled and swam in event", attendeeName));
		}
	}
}
