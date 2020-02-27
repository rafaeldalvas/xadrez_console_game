using System;
using board;
using chess;

namespace xadrez_console_game {
    class Program {
        static void Main(string[] args) {
            try {
                PlayingChess playing = new PlayingChess();
                while (!playing.finished) {
                    Console.Clear();
                    Screen.printBoard(playing.board);
                    Console.WriteLine();
                    Console.Write("Type the origin: ");
                    Position origin = Screen.captureChessPosition().toPosition();
                    bool[,] possiblePositions = playing.board.piece(origin).possibleMove();
                    Console.Clear();
                    Screen.printBoard(playing.board, possiblePositions);
                    Console.WriteLine();
                    Console.Write("Type the destination: ");
                    Position destination = Screen.captureChessPosition().toPosition();
                    playing.moveExec(origin, destination);
                }
            } catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
