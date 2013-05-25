using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Observer.Contract;

namespace DesignPatterns.Observer
{
	public class ElectionMap : IObserver
	{
		private Election ElectionData;
		private IList<Party> PartyVotes;

		public ElectionMap(Election electionData)
		{
			ElectionData = electionData;
			PartyVotes = new List<Party>();
		}

		public void Update()
		{
			PartyVotes = ElectionData.GetVotes();
		}

		public string Display()
		{
			List<Party> PartiesOrderedByVotes = PartyVotes.OrderByDescending(p => p.Votes).ToList();

			var resultsBuilder = new StringBuilder();
			PartiesOrderedByVotes.ForEach(p => resultsBuilder.AppendLine(DisplayPartyMap(p)));

			return resultsBuilder.ToString();
		}

		private string DisplayPartyMap(Party party)
		{
			return string.Format("{0} region coloured {1}.", party.Votes, party.PartyType.ToString());
		}
	}
}
