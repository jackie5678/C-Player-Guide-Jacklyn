using System;
using System.Dynamic;
using static Application.Arrow;
using static System.Formats.Asn1.AsnWriter;

namespace Application
{
    class Program
    {


        public static void Main(String[] args)
        {
            VinArrow vinArrow = new VinArrow();
            vinArrow.RunArrow();
        }
    }



  
}