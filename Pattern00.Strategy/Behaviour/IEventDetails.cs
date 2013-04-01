using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern00.Strategy.Behaviour
{
	public interface IEventDetails
	{
		string EventName { get; set; }
		void DisplayEventDetails();
	}
}
