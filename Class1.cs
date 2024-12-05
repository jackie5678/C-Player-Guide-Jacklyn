using System;

public class Class1
{
	public Class1()
	{
        int maxCityHealth = 15;
        int currentCityHealth = 15;
        int maxMantiHealth = 10;
        int currentMantiHealth = 10;
        int cityAttack = 1;
        int mantiAttack = 1;

        int range;

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Title = "Hunting The Manticore";
        MainGame();




        void MainGame()
        {
            GameString("Welcome To Hunting The Manticore");
            GameString("Press Any Key To Start");

            Console.ReadKey();
            Console.Clear();

            GameString("The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be destroyed, or the city will fall.");

            GameString("You are the city’s last hope. You must defend the City and defeat the Manticore before it’s too late.");

            GameString("You have 15 health points. The Manticore has 10 health points. You will take turns attacking each other.");

            GameString("Player 1, you will go first.");

            GameString("Player 1, how far away from the city do you want to station the Manticore?");
            range = AskForRange("Enter a number between 1 and 100", 1, 100);

            Console.Clear();

            GameString("Player 1, you have positioned the Manticore. It is now Player 2’s turn.");

            GameString("Player 2, time To find the,Manticore distnce from Consolas and attack it with the city magic cannon.");
            GameString("------------------------------------------------------------------------");

            TurnCounter(range);
        }




        void TurnCounter(int inputRange)
        {
            int turn = 1;

            while (maxCityHealth > 0 || maxMantiHealth > 0)
            {

                GameString($"Status: Turn:{turn} | City: {currentCityHealth}/{maxCityHealth} | Manticore: {currentMantiHealth}/{maxMantiHealth}");

                int rangeGuess = AskForRange("Enter the target location for the cannon, the distance is between 1 and 100", 1, 100);

                if (rangeGuess == inputRange)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    GameString("You hit the Manticore!");
                    PlayerAttack(turn, true);
                }
                else if (rangeGuess < inputRange)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    GameString("You missed the Manticore, That round OVERSHOT the target!");
                    PlayerAttack(turn, false);
                }
                else if (rangeGuess > inputRange)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    PlayerAttack(turn, false);
                    GameString("You missed the Manticore, That round OVERSHOT the target!");
                }
                GameString("------------------------------------------------------------------------");

                turn++;

                if (currentCityHealth <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    GameString("The Manticore has destroyed the city. The city has fallen.");
                    GameString("Game Over");

                    break;
                }
                else if (currentMantiHealth <= 0)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    GameString("The Manticore has been destroyed! The city is safe.");
                    GameString("You Win!");
                    break;
                }
            }
        }


        int ReduceCityHealth()
        {
            currentCityHealth -= mantiAttack;
            return currentCityHealth;
        }

        int ReduceMantiHealth(int attack)
        {
            currentMantiHealth -= attack;
            return currentMantiHealth;

        }

        void PlayerAttack(int turn, bool isHit = false)
        {
            int currentAttack = cityAttack;
            int attackCounter = turn;


            if (attackCounter % 3 == 0 && attackCounter % 5 == 0)
            {
                currentAttack = 10;

            }
            else if (attackCounter % 3 == 0)
            {
                currentAttack = 3;

            }
            else if (attackCounter % 5 == 0)
            {
                currentAttack = 5;

            }
            else
            {
                currentAttack = 1;
            }

            if (isHit)
            {
                ReduceMantiHealth(currentAttack);
            }
            else
            {
                ReduceCityHealth();
            }

            GameString($"The cannon is expected to do {currentAttack} damage to the Manticore this turn.");


            attackCounter++;

        }




        int AskForNumber(string text)
        {

            Console.WriteLine(text);
            text = Console.ReadLine();
            int number = Convert.ToInt32(text);

            return number;
        }

        int AskForRange(string text, int min, int max)
        {
            int input = AskForNumber(text);
            while (input < min || input > max)
            {
                Console.WriteLine("Invalid Range Input, try again");
                Console.WriteLine(text);
                input = AskForNumber(text);
            }
            return input;
        }

        void GameString(string text)
        {
            Console.WriteLine(text);
        }
    }
}
