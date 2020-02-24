using System;
using board;
using chess;

namespace xadrez_console_game {
    class Program {
        static void Main(string[] args) {
            try {
                Board board = new Board(8, 8);
                board.insertPiece(new Tower(board, Color.Black), new Position(0, 0));
                board.insertPiece(new King(board, Color.White), new Position(1, 3));
                board.insertPiece(new Tower(board, Color.Black), new Position(4, 3));
                Screen.printBoard(board);
            } catch (BoardException e) {
                Console.WriteLine(e.Message);
            }

            //ChessPosition pos = new ChessPosition('c', 7);
            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosition());

            Console.ReadLine();
        }
    }
}
