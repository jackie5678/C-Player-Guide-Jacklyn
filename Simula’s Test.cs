using System;

public class ChestIf
{
	public void SimulasTest()
	{
        Console.Title = "Simula’s Tes";
        Console.ForegroundColor = ConsoleColor.Cyan;

        Chest();

        void Chest()
        {
            string input = "";
            CHESTSTATE chestState = CHESTSTATE.LOCK;

            GameString("The see a chest in front of you. What would you like to do?");
            GameString("You dont know its current state");
            GameString("Here are your options");
            GameString("1. Unlock the chest : Type unlock");
            GameString("2. Open the chest: Type open");
            GameString("3. Lock the chest: Type lock");
            GameString("You can type : close : when the chest is open to close it");

            while (true)
            {
                input = InteractWithChest(input);

                if (input == "LOCK")
                {
                    if (chestState == CHESTSTATE.LOCK)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest is already locked!");
                    }
                    else if (chestState == CHESTSTATE.OPEN)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest needs to be closed first!");
                    }
                    else if (chestState == CHESTSTATE.CLOSE || chestState == CHESTSTATE.UNLOCK)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        chestState = CHESTSTATE.LOCK;
                        GameString("The chest is now locked.");
                    }
                }
                else if (input == "UNLOCK")
                {
                    if (chestState == CHESTSTATE.UNLOCK)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest is already unlocked!");
                    }
                    else if (chestState == CHESTSTATE.OPEN)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest is already unlocked!");
                    }
                    else if (chestState == CHESTSTATE.CLOSE)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest is already unlocked!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        chestState = CHESTSTATE.UNLOCK;
                        GameString("The chest is now unlocked.");
                    }
                }
                else if (input == "OPEN")
                {
                    if (chestState == CHESTSTATE.LOCK)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest is locked, you need to unlock it first!");
                    }
                    else if (chestState == CHESTSTATE.OPEN)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest is already open!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        chestState = CHESTSTATE.OPEN;
                        GameString("The chest is now open.");
                    }
                }
                else if (input == "CLOSE")
                {
                    if (chestState == CHESTSTATE.OPEN)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        chestState = CHESTSTATE.CLOSE;
                        GameString("The chest is now closed.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        GameString("The chest needs to be opened first!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    GameString("Invalid Input!");
                }
            }
        }

        void GameString(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine();
        }

        string InteractWithChest(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            text = Console.ReadLine();
            text = text.ToUpper();
            Console.WriteLine();
            return text;
        }
    }

    enum CHESTSTATE
    {
        LOCK,
        UNLOCK,
        OPEN,
        CLOSE
    }
}

