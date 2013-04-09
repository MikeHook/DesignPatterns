using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy.AttendeeBehaviours
{
	public class DontCompete : ICompeteBehaviour
	{
		public void Compete(string attendeeName, IList<string> results)
		{
			//Do nothing here as not competing
		}
	}
}
