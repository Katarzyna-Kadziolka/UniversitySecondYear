using System;

namespace RefactorBetter {
    public class Display : IDisplay {
        public void DisplayStartGameView() {
            Console.WriteLine(" -- Tic Tac Toe -- ");
            Console.Clear();
        }
        public void AskForAnswer(Player player) {
            Console.WriteLine();
            Console.WriteLine($"What box do you want to place {player} in? (1-9)");
            Console.Write("> ");
        }
        public void DisplayLoss() {
            Console.WriteLine();
            Console.WriteLine("No one won.");
            Console.ReadKey();
            Environment.Exit(1);
        }
        public void DisplayWinner(Player player) {
            Console.WriteLine();
            Console.WriteLine($"The winner is {player}!");
            Console.ReadKey();
        }

        public void DisplayError(string message) {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to try again..");
            Console.ReadKey();
        }
    }
}