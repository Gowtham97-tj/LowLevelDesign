using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Solution
{
    public class CurrentScoreDisplayNew : IObserver
    {
        private int runs, wickets;
        private float overs;

        public void update(int runs, int wickets,
                           float overs)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.overs = overs;
            display();
        }

        public void display()
        {
            Console.WriteLine("\nCurrent Score Display:\n"
                               + "Runs: " + runs +
                               "\nWickets:" + wickets +
                               "\nOvers: " + overs);
        }
    }
}
