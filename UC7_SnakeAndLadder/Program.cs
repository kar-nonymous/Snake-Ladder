using System;

namespace UC7_SankeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPos = 0;
            int finalPos = 100;
            int diceCount = 0;
            const int PLAYER_COUNT = 2;
            const int NO_PLAY = 1;
            const int LADDER_UP = 2;
            const int SNAKE_BITE = 3;
            int[] PlayerCurrentPosition = new int[PLAYER_COUNT];
            for (int i = 0; i < PLAYER_COUNT; i++)
                PlayerCurrentPosition[i] = initialPos;
            int currentPos = 0;
            Random random = new Random();

            Console.WriteLine("Welcome to Snake and Ladder game");
            while (PlayerCurrentPosition[currentPos] < finalPos)
            {
                int dice = random.Next(1, 7);
                Console.WriteLine("Die Number is {0}", dice);
                int option = random.Next(1, 4);
                Console.WriteLine("Option is {0}", option);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER_UP:
                        if (PlayerCurrentPosition[currentPos] + dice <= finalPos)
                            PlayerCurrentPosition[currentPos] += dice;
                        break;
                    case SNAKE_BITE:
                        PlayerCurrentPosition[currentPos] -= dice;
                        if (PlayerCurrentPosition[currentPos] < 0)
                            PlayerCurrentPosition[currentPos] = 0;
                        break;
                    default:
                        break;
                }
                diceCount++;
                if (currentPos < PLAYER_COUNT-1)
                    currentPos += 1;
                else currentPos = 0;
            }
            for (int i = 0; i < PLAYER_COUNT; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ", Current Position " + PlayerCurrentPosition[i]);
            }
            //Console.WriteLine("Final Position is {0}", initialPos);
            Console.WriteLine("Total Dice Count {0}", diceCount);
            Console.WriteLine("Winner is Player {0}", currentPos + 1);

        }

    }
}
