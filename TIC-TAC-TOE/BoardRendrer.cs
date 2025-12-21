using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.TIC_TAC_TOE
{
    internal class BoardRendrer
    {

        Board board = new Board();

        public BoardRendrer(Board board)
        {
            this.board = board;
        }

       public void DisplayBoard()
       {
            Console.WriteLine();
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine($"| {board.GameBoard[0, 0]} | {board.GameBoard[1, 0]} | {board.GameBoard[2, 0]} |");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine($"| {board.GameBoard[0, 1]} | {board.GameBoard[1, 1]} | {board.GameBoard[2, 1]} |");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine($"| {board.GameBoard[0, 2]} | {board.GameBoard[1, 2]} | {board.GameBoard[2, 2]} |");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine();
       }

        public void DisplayInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The board values can be set using numbers");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine($"| 1 | 2 | 3 |");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine($"| 4 | 5 | 6 |");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine($"| 7 | 8 | 9 |");
            Console.WriteLine($"+---+---+---+");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
