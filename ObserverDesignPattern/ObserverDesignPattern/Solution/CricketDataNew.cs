using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Solution
{
    public class CricketDataNew : ISubject
    {
        int runs;
        int wickets;
        float overs;
        List<IObserver> observerList;

        public CricketDataNew()
        {
            observerList = new List<IObserver>();
        }
        
        public void registerObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void unregisterObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (var item in observerList)
            {
                item.update(runs, wickets, overs);
            }
        }

        // get latest runs from stadium
        private int getLatestRuns()
        {
            // return 90 for simplicity
            return 90;
        }

        // get latest wickets from stadium
        private int getLatestWickets()
        {
            // return 2 for simplicity
            return 2;
        }

        // get latest overs from stadium
        private float getLatestOvers()
        {
            // return 90 for simplicity
            return (float)10.2;
        }

        // This method is used update displays
        // when data changes
        public void dataChanged()
        {
            //get latest data
            runs = getLatestRuns();
            wickets = getLatestWickets();
            overs = getLatestOvers();

            notifyObservers();
        }
    }
}
