using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Solution
{
    public class AverageScoreDisplayNew :IObserver
    {
        private float runRate;
        private int predictedScore;

        public void update(int runs, int wickets,
                           float overs)
        {
            this.runRate = (float)runs / overs;
            this.predictedScore = (int)(this.runRate * 50);
            display();
        }

        public void display()
        {
            Console.WriteLine("\nAverage Score Display: \n"
                               + "Run Rate: " + runRate +
                               "\nPredictedScore: " +
                               predictedScore);
        }
    }
}
