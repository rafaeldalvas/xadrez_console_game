using System;
using board;

namespace chess {
    class PlayingChess {
        public Board board { get; private set; }
        private int move;
        private Color currentPlayer;
        public bool finished { get; private set; }

        public PlayingChess() {
            board = new Board(8, 8);
            move = 1;
            currentPlayer = Color.White;
            insertAllPieces();
            finished = false;
        }
        public void moveExec(Position origin, Position destination) {
            Piece p = board.removePiece(origin);
            p.moveCounterInc();
            Piece piaceCatch = board.removePiece(destination);
            board.insertPiece(p, destination);
        }
        private void insertAllPieces() {
            board.insertPiece(new Tower(board, Color.White), new ChessPosition('c', 1).toPosition());
            board.insertPiece(new Tower(board, Color.White), new ChessPosition('c', 2).toPosition());
            board.insertPiece(new Tower(board, Color.White), new ChessPosition('d', 2).toPosition());
            board.insertPiece(new Tower(board, Color.White), new ChessPosition('e', 2).toPosition());
            board.insertPiece(new Tower(board, Color.White), new ChessPosition('e', 1).toPosition());
            board.insertPiece(new King(board, Color.White), new ChessPosition('d', 1).toPosition());

            board.insertPiece(new Tower(board, Color.Black), new ChessPosition('c', 7).toPosition());
            board.insertPiece(new Tower(board, Color.Black), new ChessPosition('c', 8).toPosition());
            board.insertPiece(new Tower(board, Color.Black), new ChessPosition('d', 7).toPosition());
            board.insertPiece(new Tower(board, Color.Black), new ChessPosition('e', 7).toPosition());
            board.insertPiece(new Tower(board, Color.Black), new ChessPosition('e', 8).toPosition());
            board.insertPiece(new King(board, Color.Black), new ChessPosition('d', 8).toPosition());
        }
    }
}
