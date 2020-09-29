using System;

namespace Snake_and_ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPos = 0;
            int finalPos = 100;
            int diceCount = 0;
            const int NO_PLAY = 1;
            const int LADDER_UP = 2;
            const int SNAKE_BITE = 3;
            Random random = new Random();
            
            Console.WriteLine("Welcome to Snake and Ladder game");
            while(initialPos < finalPos)
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
                        if (initialPos + dice <= finalPos)
                            initialPos += dice;
                        break;
                    case SNAKE_BITE:
                        initialPos -= dice;
                        if (initialPos < 0)
                            initialPos = 0;
                        break;
                    default:
                        break;
                }
                diceCount++;

            }
            Console.WriteLine("Final Position is {0}", initialPos);
            Console.WriteLine("Total Dice Count {0}", diceCount);

        }

    }
}
