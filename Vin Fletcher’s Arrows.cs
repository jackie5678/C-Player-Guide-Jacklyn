using System;
using static Application.Arrow;

namespace Application
{
    class VinArrow
    {
        public void RunArrow()
        {
            Arrow arrow = new Arrow();

            Console.Title = "Vin Flether's Arrow Shop";

            GameString("Welcome to Vin Flether's Arrow Shop!");
            GameString("What type of arrow would you like to purchase?");

          

            
            float lengthInput;
            int gameInput;

            while (true)
            {
                GameString("Please input the optionn number for the type of arrow you would like to purchase.");
                GameString("1. Custom Arrow");
                GameString("2. Premade Arrow");

                gameInput = Convert.ToInt32(Console.ReadLine());

                if (gameInput == 1)
                {
                    CustomArrow();
                    break;
                }
                else if (gameInput == 2)
                {
                    PremadArrow();
                    break;
                }
                else
                {
                    GameString("Invalid input. Please try again.");
                }
            }


          



            void PremadArrow()
            {
                int input;

                while (true)
                {
                    GameString("Please select the type of premade arrow you would like to purchase.");
                    GameString("1. Elite Arrow");
                    GameString("2. Beginner Arrow");
                    GameString("3. Marksman Arrow");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                   
                    switch (input)
                    {
                        case 1:
                            arrow = Arrow.CreateEliteArrow();
                            break;
                        case 2:
                            arrow = Arrow.CreaterBegginerArrow();
                            break;
                        case 3:
                            arrow = Arrow.CreateMarksmanArrow();
                            break;
                        default:
                            GameString("Invalid input. Please try again.");
                            continue;
                    }

                    Console.Clear();

                    GameString($"You chosen Arrow specifications is {arrow.MyArrowHead} ArrowHead, {arrow.MyFletching} Fletching, {arrow.GetLength()} Shaft Length.");
                    GameString($"The total cost of your arrow is {arrow.GetCost():00.00} gold.");
                    break;
                }

            }

            void CustomArrow()
            {
                int input;
                while (true)
                {
                    GameString("Choose the type of arrowhead you would like.");
                    GameString("1. Wood Arrow");
                    GameString("2. Steel Arrow");
                    GameString("3. Obsidian Arrow");

                    input = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    if (NumberInRange(input, 1, 3))
                    {
                        GetArrowType(input);
                        break;
                    }
                }

                while (true)
                {
                    GameString("What type of fletching would you like?");
                    GameString("1. Turkey Feather");
                    GameString("2. Plastic");
                    GameString("3. Goose Feather");

                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (NumberInRange(input, 1, 3))
                    {
                        GetFletchingType(input);
                        break;
                    }
                }

                while (true)
                {
                    GameString("What shaft length would you like your arrow to be?");
                    lengthInput = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine();

                    if (LengthInRange(lengthInput, 60, 100))
                    {
                        arrow.SetLength(lengthInput);
                        break;
                    }
                }

                Console.Clear();

                GameString($"You chosen Arrow specifications is {arrow.MyArrowHead} ArrowHead, {arrow.MyFletching} Fletching, {arrow.GetLength()} Shaft Length.");
                GameString($"The total cost of your arrow is {arrow.GetCost():00.00} gold.");


            }




            void GetArrowType(int input)
            {
                if (input == 1)
                {
                    arrow.MyArrowHead = ArrowHeadType.Wood;
                }
                else if (input == 2)
                {
                    arrow.MyArrowHead = ArrowHeadType.Steel;
                }
                else if (input == 3)
                {
                    arrow.MyArrowHead = ArrowHeadType.Obsidian;
                }
            }

            void GetFletchingType(int input)
            {
                if (input == 1)
                {
                    arrow.MyFletching = FletchingType.TurkeyFeather;
                }
                else if (input == 2)
                {
                    arrow.MyFletching = FletchingType.Plastic;
                }
                else if (input == 3)
                {
                    arrow.MyFletching = FletchingType.GooseFeather; 
                }
            }

            bool LengthInRange(float input, float min, float max)
            {
                if (input < min || input > max)
                {
                    GameString("Invalid input. Please try again.");
                    return false;
                }
                return true;
            }

            bool NumberInRange(int input, int min, int max)
            {
                if (input < min || input > max)
                {
                    GameString("Invalid input. Please try again.");
                    return false;
                }
                return true;
            }

            void GameString(string text)
            {
                Console.WriteLine(text);
                Console.WriteLine();
            }
        }
    }

    public class Arrow
    {

        private float _length;
        private ArrowHeadType _arrowHead;
        private FletchingType _fletching;


        public float GetLength() => _length;
        public ArrowHeadType MyArrowHead { get; set; }
        public FletchingType MyFletching { get; set; }

        public float SetLength(float value) => _length = value;
       

        public Arrow()
        {
            _length = 0;
            _arrowHead = ArrowHeadType.Wood;
            _fletching = FletchingType.TurkeyFeather;
        }


        public static Arrow CreateEliteArrow()
        {
            Arrow arrow = new Arrow();

            arrow.MyArrowHead = ArrowHeadType.Steel;
            arrow.MyFletching = FletchingType.Plastic;
            arrow.SetLength(95);

            return arrow;
        }

        public static  Arrow CreaterBegginerArrow()
        {
            Arrow arrow = new Arrow();
            arrow.MyArrowHead = ArrowHeadType.Wood;
            arrow.MyFletching = FletchingType.GooseFeather;
            arrow.SetLength(75);
            return arrow;
        }

        public static Arrow CreateMarksmanArrow()
        {
            Arrow arrow = new Arrow();
            arrow.MyArrowHead = ArrowHeadType.Steel;
            arrow.MyFletching = FletchingType.GooseFeather;
            arrow.SetLength(65);
            return arrow;
        }


        public float GetCost()
        {
            float cost = 0;
            switch (_arrowHead)
            {
                case ArrowHeadType.Wood:
                    cost += 3;
                    break;
                case ArrowHeadType.Steel:
                    cost += 10;
                    break;
                case ArrowHeadType.Obsidian:
                    cost += 5;
                    break;
            }

            switch (_fletching)
            {
                case FletchingType.TurkeyFeather:
                    cost += 5;
                    break;
                case FletchingType.Plastic:
                    cost += 10;
                    break;
                case FletchingType.GooseFeather:
                    cost += 3;
                    break;
            }

            cost += _length * 0.05f;

            return cost;
        }

        public enum ArrowHeadType
        {
            Wood,
            Steel,
            Obsidian
        }

        public enum FletchingType
        {
            TurkeyFeather,
            Plastic,
            GooseFeather
        }
    }
}
