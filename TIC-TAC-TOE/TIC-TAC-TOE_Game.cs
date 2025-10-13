using IntroductionToC_.Fountain_Of_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.TIC_TAC_TOE
{
    internal class TIC_TAC_TOE_Game
    {

        Board board;
        BoardRendrer boardRendrer;
        Player playerX;
        Player playerO;
        PlayerType playerType1;
        PlayerType playerType2;
        int turnCount = 0;


        Player currentPlayer;

        public TIC_TAC_TOE_Game()
        {
            board = new Board();
            boardRendrer = new BoardRendrer(board);
            playerType1 = PlayerType.XPLayer;
            playerType2 = PlayerType.OPlayer;
            playerX = new Player(playerType1);
            playerO = new Player(playerType2);
            currentPlayer = playerX;

        }

        public void Run()
        {
           
            Console.WriteLine("Welcome To TIC-TAC-TOE");
            boardRendrer.DisplayInstructions();

            while (turnCount < 9)
            {
             
                Console.WriteLine($"It is currently {currentPlayer.TYPE} turn");

                boardRendrer.DisplayBoard();

                Console.WriteLine($"{currentPlayer.TYPE}, Please make your selection on the grid.");
                

                
                int input = GetPlayerMove();
                
                board.SetBoardValue(input, currentPlayer.TYPE);

                if (board.CheckInput(input) == false)
                {
                    Console.WriteLine("PLease Input A Valid Command");
                    Console.WriteLine();
                    continue;
                }


                if (HasWon(board))
                {
                    boardRendrer.DisplayBoard();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{currentPlayer.TYPE} HAS  WON!");
                    Console.WriteLine($"GAME OVER");
                    break;
                }


                turnCount++;
                currentPlayer = (currentPlayer == playerX) ? playerO : playerX;
            }

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"It's A DRAW");
            Console.WriteLine($"GAME OVER");
           
        }


        public bool HasWon(Board board)
        {
            string x = "X";
            string o = "O";

            // win conditions in rows 
            if ((board.GameBoard[0,0] == x)  && (board.GameBoard[1, 0] == x) && (board.GameBoard[2, 0] == x) ||
                (board.GameBoard[0, 0] == o) && (board.GameBoard[1, 0] == o) && (board.GameBoard[2, 0] == o)) return true;


            if ((board.GameBoard[0, 1] == x) && (board.GameBoard[1, 1] == x) && (board.GameBoard[2, 1] == x)  ||
                (board.GameBoard[0, 1] == o) && (board.GameBoard[1, 1] == o) && (board.GameBoard[2, 1] == o)) return true;
 

            if ((board.GameBoard[0, 2] == x) && (board.GameBoard[1, 2] == x) && (board.GameBoard[2, 2] == x) || 
                (board.GameBoard[0, 2] == o) && (board.GameBoard[1, 2] == o) && (board.GameBoard[2, 1] == o)) return true;



            // win condtiond for columns
            if ((board.GameBoard[0, 0] == x) && (board.GameBoard[0,1] == x) && (board.GameBoard[0,2] == x)  || 
                (board.GameBoard[0, 0] == o) && (board.GameBoard[0, 1] == o) && (board.GameBoard[0, 2] == o)) return true;
            


            if ((board.GameBoard[1, 0] == x) && (board.GameBoard[1, 1] == x) && (board.GameBoard[1, 2] == x) || 
                (board.GameBoard[1, 0] == o) && (board.GameBoard[1, 1] == o) && (board.GameBoard[1, 2] == o)) return true;


            if ((board.GameBoard[2, 0] == x) && (board.GameBoard[2, 1] == x) && (board.GameBoard[2, 2] == x) || 
                (board.GameBoard[2, 0] == o) && (board.GameBoard[2, 1] == o) && (board.GameBoard[2, 2] == o)) return true;


            // win conditions in  daigonal
            if ((board.GameBoard[0, 0] == x) && (board.GameBoard[1, 1] == x) && (board.GameBoard[2, 2] == x) ||
                (board.GameBoard[0, 0] == o) && (board.GameBoard[1, 1] == o) && (board.GameBoard[2, 2] == o)) return true;

            return false;
        }

        public int GetPlayerMove()
        {
            int input = Convert.ToInt32(Console.ReadLine());
         
            return input;
        }

    }
}
