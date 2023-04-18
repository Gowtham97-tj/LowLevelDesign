using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            while (true)
            {
                Console.WriteLine("Press ant key to roll the dice");
                Console.ReadLine();
                int position = game.perform();
                if (position >= 100)
                {
                    Console.WriteLine("Congratulations you won!!");
                    break;
                }
                else
                {
                    Console.WriteLine("You are in " + position + " position");
                }
            }

        }
    }
}
