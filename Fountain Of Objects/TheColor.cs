using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects
{
    public class TheColor
    {

        public void RunColor()
        {
            MyColorClass myColor = new MyColorClass(245, 255, 235);
            MyColorClass StaticColor = MyColorClass.MyPurple();

            Console.WriteLine($"Red: {myColor.Red}, Green: {myColor.Green}, Blue: {myColor.Blue}");
            Console.WriteLine($"Red: {StaticColor.Red}, Green: {StaticColor.Green}, Blue: {StaticColor.Blue}");

        }
    }

    public class MyColorClass
    {
        private int _red;
        private int _green;
        private int _blue;

        public MyColorClass(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }


        public int Red
        {
            get { return _red; }
            set { _red = value; }
        }
        public int Green
        {
            get { return _green; }
            set { _green = value; }
        }
        public int Blue
        {
            get { return _blue; }
            set { _blue = value; }
        }

        public static MyColorClass MyWhite()
        {
            MyColorClass color = new MyColorClass(255, 255, 255);
            return color;
        }

        public static MyColorClass MyBlack()
        {
            MyColorClass color = new MyColorClass(0, 0, 0);
            return color;
        }

        public static MyColorClass MyRed()
        {
            MyColorClass color = new MyColorClass(255, 0, 0);
            return color;
        }

        public static MyColorClass MyGreen()
        {
            MyColorClass color = new MyColorClass(0, 128, 0);
            return color;
        }

        public static MyColorClass MyBlue()
        {
            MyColorClass color = new MyColorClass(0, 0, 255);
            return color;
        }
        public static MyColorClass MyYellow()
        {
            MyColorClass color = new MyColorClass(255, 255, 0);
            return color;
        }

        public static MyColorClass MyPurple()
        {
            MyColorClass color = new MyColorClass(128, 0, 128);
            return color;
        }

        public static MyColorClass MyOrange()
        {
            MyColorClass color = new MyColorClass(255, 165, 0);
            return color;
        }

    }

}
