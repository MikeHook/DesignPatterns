using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer.Contract
{
	public interface ISubject
	{
		IList<IObserver> Observers { get; set; }

		void Register(IObserver observer);
		void Unregister(IObserver observer);
		void Notify();

	}
}
