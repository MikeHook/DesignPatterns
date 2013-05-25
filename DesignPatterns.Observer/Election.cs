using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Observer.Contract;

namespace DesignPatterns.Observer
{
	public class Election : ISubject
	{
		public IList<IObserver> Observers { get; set; }
		private IList<Party> Parties;

		public Election()
		{
			Observers = new List<IObserver>();
			Parties = new List<Party>() {	
				new Party(PartyType.Blue, 0),
				new Party(PartyType.Green, 0),
				new Party(PartyType.Red, 0),
				new Party(PartyType.Yellow, 0)};	
		}

		public void Register(IObserver observer)
		{
			Observers.Add(observer);
		}

		public void Unregister(IObserver observer)
		{
			Observers.Remove(observer);

		}

		public void Notify()
		{
			foreach (var observer in Observers)
			{
				observer.Update();
			}
		}

		public IList<Party> GetVotes()
		{
			return Parties;
		}

		/// <summary>
		/// Simulate the election data object receiving a new vote
		/// </summary>
		public void SetVote(PartyType partyType)
		{
			var party = Parties.SingleOrDefault(p => p.PartyType == partyType);
			party.Votes++;		
		}

		

	}
}
