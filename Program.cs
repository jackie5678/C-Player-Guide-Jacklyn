using System;
using System.Dynamic;
using static Application.Arrow;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            VinArrow vinArrow = new VinArrow();
            vinArrow.RunArrow();
        }
    }


    class Rectangle
    {
        private float _width;
        private float _height;
        private float _area;
        public Rectangle(float width, float height)
        {
            _width = width;
            _height = height;
        }
       public float GetWidth() => _width;
       public float GetHeight() => _height;
       public float GetArea() => _width * _height;
       
        public void SetWidth(float value) => _width = value;
        public void SetHeight(float value) => _height = value;


    }
}
