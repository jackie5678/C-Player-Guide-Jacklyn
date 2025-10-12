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


        public void SetBoardValue(int input, PlayerType player)
        {

             CheckInput(input);

            if (ValidateBoardInput(input))
            {
                return;
            }
            if (input == 1)
            {
                if(player == PlayerType.XPLayer)
                {
                   GameBoard[0, 0] = "X";
                }
                else
                {
                    GameBoard[0, 0] = "O";
                }
                
            }

            if (input == 2)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[1, 0] = "X";
                }
                else
                {
                    GameBoard[1, 0] = "O";
                }

            }
          
            if (input == 3)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[2, 0] = "X";
                }
                else
                {
                    GameBoard[2, 0] = "O";
                }

            }

            if (input == 4)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[0, 1] = "X";
                }
                else
                {
                    GameBoard[0, 1] = "O";
                }

            }

            if (input == 5)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[1, 1] = "X";
                }
                else
                {
                    GameBoard[1, 1] = "O";
                }

            }

            if (input == 6)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[2, 1] = "X";
                }
                else
                {
                    GameBoard[2, 1] = "O";
                }

            }

            if (input == 7)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[0, 2] = "X";
                }
                else
                {
                    GameBoard[0, 2] = "O";
                }

            }

            if (input == 8)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[1, 2] = "X";
                }
                else
                {
                    GameBoard[1, 2] = "O";
                }

            }

            if (input == 9)
            {
                if (player == PlayerType.XPLayer)
                {
                    GameBoard[2, 2] = "X";
                }
                else
                {
                    GameBoard[2, 2] = "O";
                }

            }


        }

        public bool ValidateBoardInput(int input)
        {

            string positionValue = "";

            switch (input)
            {
                case 1: positionValue = GameBoard[0, 0]; break;
                case 2: positionValue = GameBoard[0, 1]; break;
                case 3: positionValue = GameBoard[0, 2]; break;
                case 4: positionValue = GameBoard[1, 0]; break;
                case 5: positionValue = GameBoard[1, 1]; break;
                case 6: positionValue = GameBoard[1, 2]; break;
                case 7: positionValue = GameBoard[2, 0]; break;
                case 8: positionValue = GameBoard[2, 1]; break;
                case 9: positionValue = GameBoard[2, 2]; break;
            }

            if(positionValue == "X" || positionValue == "O")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THAT POSITION IS OCCUPIED!");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }

            return false;
        }

        




        private bool CheckInput(int input)
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
            return false;
        }

     


    }
       
    
}
