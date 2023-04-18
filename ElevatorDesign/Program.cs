using System;
using System.Threading;

namespace ElevatorDesinPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//where the magic happens...
			Start:
				Console.WriteLine("Welcome to David's awesome elevator!!");
				Console.WriteLine("How tall is the building that this elevator will be in?");

				int floor; 
			    string floorInput; 
			    Elevator elevator;

				floorInput = Console.ReadLine();

				if (Int32.TryParse(floorInput, out floor))
					elevator = new Elevator(floor);
				else
				{
					Console.WriteLine("That' doesn't make sense...");
					Console.Beep();
					Thread.Sleep(2000);
					Console.Clear();
					goto Start;
				}
				string input = string.Empty;

				while (input != "QUIT")
				{
					Console.WriteLine("Please press which floor you would like to go to");

					input = Console.ReadLine();
					if (Int32.TryParse(input, out floor))
						elevator.FloorPress(floor);
					else if (input == "QUIT")
						Console.WriteLine("GoodBye!");
					else
						Console.WriteLine("You have pressed an incorrect floor, Please try again");
				}
		}
	}
}
