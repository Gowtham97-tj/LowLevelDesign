using System;

namespace FlyWeightPattern
{
    public class Program
    {
        private static String[] playerType =
                    {"Terrorist", "CounterTerrorist"};
        private static String[] weapons =
          {"AK-47", "Maverick", "Gut Knife", "Desert Eagle"};
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                /* getPlayer() is called simply using the class
                   name since the method is a static one */
                IPlayer p = PlayerFactory.getPlayer(getRandPlayerType());

                /* Assign a weapon chosen randomly uniformly
                   from the weapon array  */
                p.assignWeapon(getRandWeapon());

                // Send this player on a mission
                p.mission();
            }
        }

        public static String getRandPlayerType()
        {
            Random r = new Random();

            // Will return an integer between [0,2)
            int randInt = r.Next(playerType.Length);

            // return the player stored at index 'randInt'
            return playerType[randInt];
        }
        public static String getRandWeapon()
        {
            Random r = new Random();

            // Will return an integer between [0,5)
            int randInt = r.Next(weapons.Length);

            // Return the weapon stored at index 'randInt'
            return weapons[randInt];
        }
    }
}
