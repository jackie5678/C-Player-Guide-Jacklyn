using IntroductionToC_.Asteroids;
using IntroductionToC_.Fountain_Of_Objects;
using IntroductionToC_.TIC_TAC_TOE;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Sockets;
using static Application.Arrow;
using static Application.Program;
using static System.Formats.Asn1.AsnWriter;

namespace Application
{
    class Program
    {

        public static void Main(String[] args)
        {
           
           TIC_TAC_TOE_Game game =  new TIC_TAC_TOE_Game();

            game.Run();
          
            
        }
    }
}
