using board;

namespace chess {
    class Tower : Piece {
        public Tower(Board board, Color color) : base(board, color) {
        }
        public override string ToString() {
            return "T";
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
            while (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color) {
                    break;
                }
                pos.line--;
            }
            //down
            pos.defineValue(position.line + 1, position.column);
            while (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color) {
                    break;
                }
                pos.line++;
            }
            //right
            pos.defineValue(position.line, position.column + 1);
            while (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color) {
                    break;
                }
                pos.column++;
            }
            //left
            pos.defineValue(position.line, position.column - 1);
            while (board.validatesPositions(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color) {
                    break;
                }
                pos.column--;
            }
            return mat;
        }
    }
}