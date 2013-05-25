using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
	public class Party
	{
		public Party(PartyType partyType, int votes)
		{
			PartyType = partyType;
			Votes = votes;
		}

		public PartyType PartyType { get; set; }
		public int Votes { get; set; }

	}
}
