namespace RefactorBetter {
    public class BoardBuilder {
        public Board BuildClassicTicTacToeBoard() {
            return new Board(new GameState(), new AnswerValidator(9));
        }
    }
}