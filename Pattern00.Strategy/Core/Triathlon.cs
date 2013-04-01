using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pattern00.Strategy.Behaviour;

namespace Pattern00.Strategy.Core
{
	public class Triathlon : Event
	{
		public Triathlon(ITriathlonDetails triathlonDetails) : base(triathlonDetails) { }		
	}
}
