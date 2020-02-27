using board;

namespace chess {
    class King : Piece {
        public King(Board board, Color color) : base(board, color) {
        }
        public override string ToString() {
            return "K";
        }
        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }
        public override bool[,] possibleMove() {
            bool[,] mat = new bool[board.lines, board.columns];
            Position pos = new Position(0, 0);
            //up
            pos.defineValue(position.line - 1, position.column);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //ne
            pos.defineValue(position.line - 1, position.column + 1);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //right
            pos.defineValue(position.line, position.column + 1);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //se
            pos.defineValue(position.line + 1, position.column + 1);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //down
            pos.defineValue(position.line + 1, position.column);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //so
            pos.defineValue(position.line + 1, position.column - 1);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //left
            pos.defineValue(position.line, position.column - 1);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            //no
            pos.defineValue(position.line - 1, position.column - 1);
            if (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }
            return mat;
        }
    }
}
