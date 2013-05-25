using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DesignPatterns.Observer;
using NSubstitute;

namespace DesignPatterns.Tests
{
	/// <summary>
	/// These are tests for the kata implementing the Observer pattern:
	/// Define a one-to-many relationship between objects 
	/// so that when one object changes state all it dependants are notified and updated automatically
	/// </summary>
	[TestFixture]
	public class ObserverTests
	{
		Election election;
		LeaderBoard leaderBoard;
		ElectionMap electionMap;
		SwingOmeter swingOmeter;

		[SetUp]
		public void SetUp()
		{
			election = new Election();
			leaderBoard = new LeaderBoard(election);
			electionMap = new ElectionMap(election);
			swingOmeter = new SwingOmeter(election);
		}

		[Test]
		public void CanSetGetRedVote()
		{
			election.SetVote(PartyType.Red);

			var partyVotes = election.GetVotes();

			Assert.That(partyVotes.Single(p => p.PartyType == PartyType.Red).Votes, Is.EqualTo(1));
		}

		[Test]
		public void CanRegisterObserver()
		{
			RegisterObservers();

			Assert.That(election.Observers.Contains(leaderBoard));
		}

		[Test]
		public void CanUnregisterObserver()
		{
			RegisterObservers();
			election.Unregister(leaderBoard);

			Assert.That(election.Observers.Contains(leaderBoard) == false);
		}

		[Test]
		public void CanNotifyObservers()
		{
			election = new Election();
			var leaderBoardSubstitute = Substitute.For<LeaderBoard>(election);
			election.Register(leaderBoardSubstitute);

			election.Notify();

			leaderBoardSubstitute.Received().Update();
		}

		[Test]
		public void LeaderBoardDisplaysRedVote()
		{
			RegisterObservers();

			election.SetVote(PartyType.Red);
			election.Notify();

			Assert.That(leaderBoard.Display(),Is.StringContaining("Party: Red, Votes: 1"));
		}

		[Test]
		public void AllObserversAreNotified()
		{
			RegisterObservers();

			election.SetVote(PartyType.Blue);
			election.Notify();

			Assert.That(leaderBoard.Display(), Is.StringContaining("Party: Blue, Votes: 1"));
			Assert.That(swingOmeter.Display(), Is.StringContaining("Swinging to the Blue party!"));
			Assert.That(electionMap.Display(), Is.StringContaining("1 region coloured Blue."));

		}

		private void RegisterObservers()
		{
			election.Register(leaderBoard);
			election.Register(swingOmeter);
			election.Register(electionMap);
		}

	}
}
