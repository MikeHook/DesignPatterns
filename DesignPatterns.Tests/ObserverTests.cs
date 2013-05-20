using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DesignPatterns.Observer;

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
		ElectionData Election;

		[SetUp]
		public void SetUp()
		{
			Election = new ElectionData();			
		}

	}
}
