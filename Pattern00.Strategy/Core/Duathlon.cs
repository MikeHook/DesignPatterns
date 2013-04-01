using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pattern00.Strategy.Behaviour;

namespace Pattern00.Strategy.Core
{
	public class Duathlon : Event
	{
		public Duathlon(IDuathlonDetails duathlonDetails) : base(duathlonDetails) { }		
	}
}
