﻿
namespace board {
    abstract class Piece {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int movementCount { get; protected set; }
        public Board board { get; protected set; }

        public Piece(Board board, Color color) {
            this.position = null;
            this.board = board;
            this.color = color;
            this.movementCount = 0;
        }
        public void moveCounterInc() {
            movementCount++;
        }
        public abstract bool[,] possibleMove();
    }
}
