namespace RefactorBetter {
    public class GameFactory {
        public Game CreateClassicTicTacToeGame() {
            var maxValue = 9;
            return new Game( new Board(), new GameState(maxValue), new AnswerValidator(maxValue), new Display());
        }
    }
}