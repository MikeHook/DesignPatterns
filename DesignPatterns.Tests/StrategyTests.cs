using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.AttendeeBehaviours;

namespace DesignPatterns.Tests
{
	/// <summary>
	/// These are tests for the kata implementing the Strategy pattern:
	/// Define a family of algorithms (behaviour), encapsulate each one and make them interchangeable.
	/// AKA: Separate what changes (the behaviour) from what does not.");
	/// </summary>
	[TestFixture]
	public class StrategyTests
	{
		private List<Event> Events { get; set; }

		[SetUp]
		public void SetUp()
		{
			Events = new List<Event>();
			Events.Add(new Event("London marathon"));
			Events.Add(new Event("Manchester 10K run"));
			Events.Add(new Event("Haywards Heath Triathlon"));

			//Add a marshall to each event
			Events.ForEach(e => e.EventAttendees.Add(new Marshall("Simon", new DontCompete())));
		}

		private void AddRunnersTo(Event myEvent)
		{
			ICompeteBehaviour runBehaviour = new Run();
			myEvent.EventAttendees.Add(new Runner("Bob", runBehaviour));
			myEvent.EventAttendees.Add(new Runner("Jim", runBehaviour));		
		}

		private void AddTriathletesTo(Event myEvent)
		{
			ICompeteBehaviour competeInTriBehaviour = new CompeteInTri();
			myEvent.EventAttendees.Add(new Triathlete("Mark", competeInTriBehaviour));
			myEvent.EventAttendees.Add(new Runner("Gordon", competeInTriBehaviour));
		}
		

		[Test]
		public void CanCreateLondonMarathonEvent()
		{
			Assert.That(Events.Any(e => e.Name == "London marathon"));
		}

		[Test]
		public void CanCreate10KRunEvent()
		{
			Assert.That(Events.Any(e => e.Name == "Manchester 10K run"));
		}

		[Test]
		public void CanSeeEventAttendees()
		{
			AddRunnersTo(Events[0]);

			var attendeesRendered = Events[0].RenderAttendees();
			Assert.That(attendeesRendered.ElementAt(0), Is.StringContaining("Simon"));
			Assert.That(attendeesRendered.ElementAt(1), Is.StringContaining("Bob"));
			Assert.That(attendeesRendered.ElementAt(2), Is.StringContaining("Jim"));
			Assert.That(attendeesRendered.Count(), Is.EqualTo(3));
		}

		[Test]
		public void EventAttendeesCanCompete()
		{
			AddRunnersTo(Events[0]);

			var competeList = Events[0].ConductEvent();
			foreach (var compete in competeList)
			{
				Assert.That(compete, Is.StringContaining("ran"));
			}
		}

		[Test]
		public void TriathletesCompeteCorrectly()
		{
			AddTriathletesTo(Events[2]);

			var competeList = Events[2].ConductEvent();
			foreach (var compete in competeList)
			{
				Assert.That(compete, Is.StringContaining("ran"));
				Assert.That(compete, Is.StringContaining("cycled"));
				Assert.That(compete, Is.StringContaining("swam"));
			}
		}

		[Test]
		public void RunnersDoNotCompeteCorrectlyInTriathlons()
		{
			AddRunnersTo(Events[2]);

			var competeList = Events[2].ConductEvent();
			foreach (var compete in competeList)
			{
				Assert.That(compete, Is.StringContaining("ran"));
				Assert.That(compete, Is.Not.StringContaining("cycled"));
				Assert.That(compete, Is.Not.StringContaining("swam"));
			}
		}
	}
}
