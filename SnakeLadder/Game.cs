using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class Game
    {
        private Player player;
        private List<Snake> snakes;
        private List<Ladder> ladders;
        private Random rand;
        public Game()
        {
            rand = new Random();
            player = new Player();
            player.Position = 0;
            snakes = new List<Snake>();
            ladders = new List<Ladder>();
            setSnakes();
            setLadders();
        }

        public int perform()
        {
            int number = rand.Next(1, 7);
            player.Position = player.Position + number;

            bool isSnake = false;

            foreach(var snake in snakes)
            {
                if(snake.Start == player.Position)
                {
                    isSnake = true;
                    player.Position = snake.End;
                }
            }

            if (isSnake)
                return player.Position;

            foreach (var ladder in ladders)
            {
                if (ladder.End == player.Position)
                {
                    player.Position = ladder.Start;
                }
            }

            return player.Position;
        }

        private void setSnakes()
        {
            snakes.Add(new Snake { Start = 10, End = 2 });
            snakes.Add(new Snake { Start = 20, End = 12 });
            snakes.Add(new Snake { Start = 30, End = 22 });
            snakes.Add(new Snake { Start = 40, End = 32 });
            snakes.Add(new Snake { Start = 50, End = 42 });
        }

        private void setLadders()
        {
            ladders.Add(new Ladder { Start = 5, End = 13 });
            ladders.Add(new Ladder { Start = 15, End = 75 });
            ladders.Add(new Ladder { Start = 25, End = 60 });
            ladders.Add(new Ladder { Start = 35, End = 70 });
            ladders.Add(new Ladder { Start = 45, End = 90 });
        }

    }
}
