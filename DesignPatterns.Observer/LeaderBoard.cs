using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Observer.Contract;

namespace DesignPatterns.Observer
{
	public class LeaderBoard : IObserver
	{
		private Election ElectionData;
		private IList<Party> PartyVotes;

		public LeaderBoard(Election electionData)
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
			PartiesOrderedByVotes.ForEach(p => resultsBuilder.AppendLine(DisplayParty(p)));

			return resultsBuilder.ToString();
		}

		private string DisplayParty(Party party)
		{
			return string.Format("Party: {0}, Votes: {1}", party.PartyType.ToString(), party.Votes);
		}
	}
}
