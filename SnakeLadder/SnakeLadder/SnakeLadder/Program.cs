using SnakeLadder;

public class Program
{
    public static void Main()
    {
        var game = new Game();

        while (true)
        {
            Console.WriteLine("Press any key to roll the dice");
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