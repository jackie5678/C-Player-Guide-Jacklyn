using System;
using System.Dynamic;
using static Application.Arrow;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow = new Arrow();

            Console.Title = "Vin Flether's Arrow Shop";

            GameString("Welcome to Vin Flether's Arrow Shop!");
            GameString("What type of arrow would you like to purchase?");

            GameString("1. Wood Arrow");
            GameString("2. Steel Arrow");
            GameString("3. Obsidian Arrow");

            int input;
            float lengthInput;

            while (true)
            {
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

                if (LengthInRange(lengthInput,60,100))
                {
                    arrow.Length = lengthInput;
                    break;
                }
            }

            Console.Clear();

            GameString($"You chosen Arrow specifications is {arrow.ArrowHead} ArrowHead,{arrow.Fletching} Fletching, {arrow.Length} Shaft Length");
           
            GameString($"The total cost of your arrow is {arrow.GetCost():0.00} gold.");


            void GetArrowType(int input)
            {
                if (input == 1)
                {
                   arrow.ArrowHead = ArrowHeadType.Wood;
                }
                else if (input == 2)
                {
                    arrow.ArrowHead = ArrowHeadType.Steel;
                }
                else if (input == 3)
                {
                    arrow.ArrowHead = ArrowHeadType.Obsidian;

                }
            }



            void GetFletchingType(int input)
            {
                if (input == 1)
                {
                    arrow.Fletching = FletchingType.TurkeyFeather;
                }
                else if (input == 2)
                {
                    arrow.Fletching = FletchingType.Plastic;
                }
                else if (input == 3)
                {
                    arrow.Fletching = FletchingType.GooseFeather;
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


    class Arrow
    {

        float _length;
        ArrowHeadType _arrowHead;
        FletchingType _fletching;


        public Arrow()
        {
            _length = 0;
            _arrowHead = ArrowHeadType.Wood;
            _fletching = FletchingType.TurkeyFeather;
        }


        public ArrowHeadType ArrowHead
        {
            get { return _arrowHead; }
            set { _arrowHead = value; }
        }

       


        public FletchingType Fletching
        {
            get { return _fletching; }
            set { _fletching = value; }
        }

    
        public float Length
        {
            get{ return _length; }
            set { _length = value; }
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
