using System;

public class SimulaSoupShop
{
    public void SimulaSoup()
    {

        (SoupType, MainnIgredient, Seasoning) soup = (SoupType.Soup, MainnIgredient.Mushroom, Seasoning.Sweet);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Title = "Simula Soup Shop";



        SoupMaker();


        void SoupMaker()
        {
            GameString("Welcome to Simula Soup Shop!");
            GameString("What type of soup would you like to have made?");

            GameString("1. Soup");
            GameString("2. Stew");
            GameString("3. Gumbo");
            int input;



            while (true)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (GetNumInRange(input, 1, 3))
                {
                    GetSoupType(input);
                    break;
                }

            }



            GameString("What main ingredient would you like to have in your soup?");
            GameString("1. Mushroom");
            GameString("2. Chicken");
            GameString("3. Carrots");
            GameString("4. Potatoes");

            while (true)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (GetNumInRange(input, 1, 4))
                {
                    GetIngredient(input);
                    break;
                }

            }



            GameString("What seasoning would you like to have in your soup?");
            GameString("1. Sweet");
            GameString("2. Salty");
            GameString("3. Spicy");

            while (true)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (GetNumInRange(input, 1, 3))
                {
                    GetSeasoning(input);
                    break;
                }

            }


            Console.ForegroundColor = ConsoleColor.Green;
            GameString($"YOUR ORDER IS READY! ENJOY YOUR {soup.Item3} {soup.Item2} {soup.Item1}!");

        }


        void GetSoupType(int input)
        {

            if (input == 1)
            {
                soup.Item1 = SoupType.Soup;

            }
            else if (input == 2)
            {
                soup.Item1 = SoupType.Stew;
            }
            else if (input == 3)
            {
                soup.Item1 = SoupType.Gumbo;
            }

        }



        void GetIngredient(int input)
        {

            if (input == 1)
            {
                soup.Item2 = MainnIgredient.Mushroom;
            }
            else if (input == 2)
            {
                soup.Item2 = MainnIgredient.Chicken;
            }
            else if (input == 3)
            {
                soup.Item2 = MainnIgredient.Carrots;
            }
            else if (input == 4)
            {
                soup.Item2 = MainnIgredient.Potatoes;
            }
        }


        void GetSeasoning(int input)
        {

            if (input == 1)
            {
                soup.Item3 = Seasoning.Sweet;
            }
            else if (input == 2)
            {
                soup.Item3 = Seasoning.Salty;
            }
            else if (input == 3)
            {
                soup.Item3 = Seasoning.Spicy;
            }
        }



        void GameString(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine();
        }



        bool GetNumInRange(int num, int min, int max)
        {
            if (num < min || num > max)
            {
                GameString("Invalid Input, Try again");
                return false;
            }
            return true;
        }

    }

}

enum SoupType
{
    Soup,
    Stew,
    Gumbo

}

enum MainnIgredient
{
    Mushroom,
    Chicken,
    Carrots,
    Potatoes,
}

enum Seasoning
{
    Sweet,
    Salty,
    Spicy
}
	

