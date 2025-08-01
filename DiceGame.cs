using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(2000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round.");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round.");
                }
                else
                {
                    Console.WriteLine("Draw.");
                    continue;
                }

                Console.WriteLine(
                    "The score is now... Player: " + playerPoints + " Enemy: " + enemyPoints
                );

                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("Congratulations! Player wins the game!");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine("Enemy wins the game! Better luck next time!");
            }
            else
            {
                Console.WriteLine("This game ended in a draw!");
            }

            Console.ReadKey();
        }
    }
}
