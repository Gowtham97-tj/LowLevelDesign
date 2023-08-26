using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Solution
{
    public interface IObserver
    {
        public void update(int runs, int wickets, float overs);
    }
}
