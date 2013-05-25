using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Observer.Contract;

namespace DesignPatterns.Observer
{
	public class SwingOmeter : IObserver
	{
		private Election ElectionData;
		private IList<Party> PartyVotes;

		public SwingOmeter(Election electionData)
		{
			ElectionData = electionData;
			PartyVotes = new List<Party>();
		}

		public void Update()
		{
			PartyVotes = ElectionData.GetVotes();
		}

		/// <summary>
		/// There is some complex algorithm for displaying a SwingOmeter, lets pretend its simple here
		/// </summary>
		/// <returns></returns>
		public string Display()
		{
			List<Party> PartiesOrderedByVotes = PartyVotes.OrderByDescending(p => p.Votes).ToList();
			return string.Format("Swinging to the {0} party!", PartiesOrderedByVotes.First().PartyType);
		}

	
	}
}
