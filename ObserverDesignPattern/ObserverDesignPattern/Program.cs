using ObserverDesignPattern.Problem;
using ObserverDesignPattern.Solution;
using System;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create objects for testing
            AverageScoreDisplay averageScoreDisplay =
                                           new AverageScoreDisplay();
            CurrentScoreDisplay currentScoreDisplay =
                                           new CurrentScoreDisplay();

            // Pass the displays to Cricket data
            CricketData cricketData = new CricketData(currentScoreDisplay,
                                                      averageScoreDisplay);

            // In real app you would have some logic to call this
            // function when data changes
            cricketData.dataChanged();

            Console.WriteLine("----------------------------------");

            // create objects for testing
            AverageScoreDisplayNew averageScoreDisplayNew =
                              new AverageScoreDisplayNew();
            CurrentScoreDisplayNew currentScoreDisplayNew =
                              new CurrentScoreDisplayNew();

            // pass the displays to Cricket data
            CricketDataNew cricketDataNew = new CricketDataNew();

            // register display elements
            cricketDataNew.registerObserver(averageScoreDisplayNew);
            cricketDataNew.registerObserver(currentScoreDisplayNew);

            // in real app you would have some logic to
            // call this function when data changes
            cricketDataNew.dataChanged();

            Console.WriteLine("ooooooooooooo");

            //remove an observer
            cricketDataNew.unregisterObserver(averageScoreDisplayNew);

            // now only currentScoreDisplay gets the
            // notification
            cricketData.dataChanged();
        }
    }
}
