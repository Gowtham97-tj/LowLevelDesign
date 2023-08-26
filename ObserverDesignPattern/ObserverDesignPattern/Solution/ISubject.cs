using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Solution
{
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void unregisterObserver(IObserver o);
        public void notifyObservers();
    }
}
