using System;
using board;

namespace xadrez_console_game {
    class Program {
        static void Main(string[] args) {
            Board board = new Board(8, 8);
            Screen.printBoard(board);
            Console.ReadLine();
        }
    }
}
