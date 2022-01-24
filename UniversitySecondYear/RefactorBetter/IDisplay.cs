namespace RefactorBetter {
    public interface IDisplay {
        public void DisplayStartGameView();
        public void AskForAnswer(Player player, int maxValue);
        public void DisplayLoss();
        public void DisplayWinner(Player player);
        public void DisplayError(string message);
    }
}