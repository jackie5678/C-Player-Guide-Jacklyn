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

          

            int input;
            float lengthInput;

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

            GameString($"You chosen Arrow specifications is {arrow.GetArrowHeadType()} ArrowHead, {arrow.GetFletching()} Fletching, {arrow.GetLength()} Shaft Length.");
            GameString($"The total cost of your arrow is {arrow.GetCost():00.00} gold.");

            void GetArrowType(int input)
            {
                if (input == 1)
                {
                    arrow.SetArrowHeadType(ArrowHeadType.Wood);
                }
                else if (input == 2)
                {
                    arrow.SetArrowHeadType(ArrowHeadType.Steel);
                }
                else if (input == 3)
                {
                    arrow.SetArrowHeadType(ArrowHeadType.Obsidian);
                }
            }

            void GetFletchingType(int input)
            {
                if (input == 1)
                {
                    arrow.SetFletching(FletchingType.TurkeyFeather);
                }
                else if (input == 2)
                {
                    arrow.SetFletching(FletchingType.Plastic);
                }
                else if (input == 3)
                {
                    arrow.SetFletching(FletchingType.GooseFeather); 
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
        public ArrowHeadType GetArrowHeadType() => _arrowHead;
        public FletchingType GetFletching() => _fletching;

        public float SetLength(float value) => _length = value;
        public ArrowHeadType SetArrowHeadType(ArrowHeadType value) => _arrowHead = value;
        public FletchingType SetFletching(FletchingType value) => _fletching = value;

        public Arrow()
        {
            _length = 0;
            _arrowHead = ArrowHeadType.Wood;
            _fletching = FletchingType.TurkeyFeather;
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
