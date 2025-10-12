using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.TIC_TAC_TOE
{
    internal class Board
    {

      public string[,] GameBoard { get; private set; }

        
        public Board()
        {
           GameBoard = new string[,] { { "*", "*", "*", }, { "*", "*", "*", } , { "*", "*", "*", } };
        }


        public bool SetBoardValue(int input, PlayerType player)
        {
            
           if (ValidateBoardPosition(input))
           {
                return false;
           }
           string playerSymbol = "";
             
            
      
            if (player == PlayerType.XPLayer)
            {
               playerSymbol = "X";
            }
            else if(player == PlayerType.OPlayer)
            {
                playerSymbol = "O";
            }


            switch (input)
            {
                case 1:
                    GameBoard[0,0] = playerSymbol;
                   break;
                case 2:
                    GameBoard[1,0] = playerSymbol;
                    break;
                case 3:
                    GameBoard[2,0] = playerSymbol;
                    break;
                case 4: 
                    GameBoard[0,1] = playerSymbol;
                    break;
                case 5:    
                    GameBoard[1,1] = playerSymbol;
                    break;
                case 6:
                    GameBoard[2,1] = playerSymbol;
                    break;
                case 7:
                    GameBoard[0,2] = playerSymbol;
                 break;
                case 8:
                    GameBoard[1, 2] = playerSymbol;
                    break;
                case 9:
                    GameBoard[2, 2] = playerSymbol;
                    break;

            }

            return false;
        }

        public bool ValidateBoardPosition(int input)
        {

            string positionValue = "";

            switch (input)
            {
                case 1: positionValue = GameBoard[0, 0]; break;
                case 2: positionValue = GameBoard[1, 0]; break;
                case 3: positionValue = GameBoard[2, 0]; break;
                case 4: positionValue = GameBoard[0, 1]; break;
                case 5: positionValue = GameBoard[1, 1]; break;
                case 6: positionValue = GameBoard[2, 1]; break;
                case 7: positionValue = GameBoard[0, 2]; break;
                case 8: positionValue = GameBoard[1, 2]; break;
                case 9: positionValue = GameBoard[2, 2]; break;
            }

            if(positionValue == "X" || positionValue == "O")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THAT POSITION IS OCCUPIED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                return true;
            }

            return false;
        }

        




        public bool CheckInput(int input)
        {
            int[] acceptedInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            foreach(int i in acceptedInput)
            {
                if (input == i)
                return true;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return false;
        }

     


    }
       
    
}
