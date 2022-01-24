namespace RefactorBetter {
    public class GameFactory {
        public Game CreateClassicTicTacToeGame() {
            return new Game( new Board(), new GameState(), new AnswerValidator(9), new Display());
        }
    }
}