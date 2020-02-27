using System;
using board;
using chess;


namespace xadrez_console_game {
    class Screen {
        public static void printBoard(Board board) {
            for (int i = 0; i < board.lines; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++) {      
                    printPiece(board.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void printBoard(Board board, bool [,] possiblePositions) {
            ConsoleColor defultBackground = Console.BackgroundColor;
            ConsoleColor newBackground = ConsoleColor.DarkGray;
            for (int i = 0; i < board.lines; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++) {
                    if (possiblePositions[i, j]) {
                        Console.BackgroundColor = newBackground;
                    } else {
                        Console.BackgroundColor = defultBackground;
                    }
                    printPiece(board.piece(i, j));
                    Console.BackgroundColor = defultBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = defultBackground;
        }
        public static ChessPosition captureChessPosition() {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }
        public static void printPiece(Piece piece) {
            if (piece == null) {
                Console.Write("- ");
            } else {
                if (piece.color == Color.White) {
                    Console.Write(piece);
                } else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
