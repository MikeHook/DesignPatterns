using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DesignPatterns.Strategy;

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
			Events[0].EventAttendees.Add(new Runner("Bob"));

			var attendeesRendered = Events[0].RenderAttendees();
			Assert.That(attendeesRendered[0], Is.StringContaining("runner"));
			Assert.That(attendeesRendered[0], Is.StringContaining("Bob"));
		}
	}
}
