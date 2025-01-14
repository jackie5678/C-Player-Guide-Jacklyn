using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects
{
    public  class ThePoint
    {
        
        public void Run()
        {
            Point point1 = new Point();
            point1.X = 2;
            point1.Y = 3;

            Point point2 = new Point();
            point2.X = -4;
            point2.Y = 0;

            Console.WriteLine($"({point1.X},{point1.Y})");
            Console.WriteLine($"({point2.X},{point2.Y})");

            /// <summary>
            /// My X and Y properties are not immutable . I can change the values of x and y after they have been set.
            /// I did this becuase I need to get the values of x and y to display it to the user and set vlaue of my point objects i created.
            /// If I instead had a parmetrized constructor, i would be able to set the value of my point objects when they are created and get rid of the setter for the properties of X Y, and be able to get the value using the getter 
            ///to display it, making my X and Y  immutbale that way.
            /// </summary>
        }

        public class Point
        {
            private int _x;
            private int _y;

            public int X
            {
                get { return _x; }
                set { _x = value; }
            }
            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public Point()
            {
                _x = 0;
                _y = 0;
            }

        }

    }
}
