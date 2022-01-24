namespace RefactorBetter {
    class Program {
        static void Main() {

            GameFactory factory = new GameFactory();
            Game game = factory.CreateClassicTicTacToeGame();
            game.Play();
        }
    }
}