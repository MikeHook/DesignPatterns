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
		[Test]
		public void CanCreateLondonMarathonEvent()
		{
			string eventName = "London marathon";
			var myEvent = new Event(eventName);

			Assert.That(myEvent.Name, Is.EqualTo(eventName));

		}
	}
}
