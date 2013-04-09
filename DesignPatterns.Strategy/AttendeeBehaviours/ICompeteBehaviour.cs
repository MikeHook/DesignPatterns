using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
	public interface ICompeteBehaviour
	{
		void Compete(string attendeeName, IList<string> results);
	}
}
