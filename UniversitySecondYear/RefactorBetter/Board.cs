using System;
using System.Linq;

namespace RefactorBetter {
    public class Board {
        public string[][] Boxes { get; set; }
        private readonly GameState _gameState;
        private AnswerValidator _validator;

        public Board(GameState gameState, AnswerValidator validator) {
            _gameState = gameState;
            _validator = validator;
            StartGame();
            CreateBoxes();
            Play();
        }

        private void Play() {
            while (CheckWin() == Player.None) {
                if (_gameState.MoveCount == 9) {
                    DisplayLoss();
                }

                _gameState.NextTurn();
                WriteBoard();
                AskForAnswer();
                var answer = Console.ReadLine();
                while (!CanBeInsert) {
                    while (!_validator.Validate(answer)) {
                        Console.WriteLine(_validator.Message);
                        Console.WriteLine("Press any key to try again..");
                        Console.ReadKey();
                        AskForAnswer();
                        answer = Console.ReadLine();
                    }
                    InsertAnswer(Convert.ToInt32(answer));
                }


                
            }

            DisplayWinner();
        }

        private void DisplayWinner() {
            Console.Clear();
            WriteBoard();
            Console.WriteLine();
            Console.WriteLine("The winner is {0}!", _gameState.Player);
            Console.ReadKey();
        }

        private void InsertAnswer(int answer) {
            var isNotEmpty = true;
            while (isNotEmpty) {
                var boxNumber = 0;
                foreach (var box in Boxes) {
                    for (int j = 0; j < box.Length; j++) {
                        boxNumber++;
                        if (boxNumber == answer) {
                            if (box[j] == " ") {
                                box[j] = _gameState.Player.ToString();
                                isNotEmpty = false;
                            }
                            else {
                                NotVacantError();
                            }
                        }
                    }
                }
            }
        }

        private void NotVacantError() {
            Console.WriteLine();
            Console.WriteLine("Error: box not vacant!");
            Console.WriteLine("Press any key to try again..");
            Console.ReadKey();
        }

        private void AskForAnswer() {
            Console.WriteLine();
            Console.WriteLine("What box do you want to place {0} in? (1-9)", _gameState.Player);
            Console.Write("> ");
        }

        private void CreateBoxes() {
            Boxes = new string[3][];
            for (int i = 0; i < Boxes.Length; i++) {
                Boxes[i] = new string[3];
                for (int j = 0; j < Boxes[i].Length; j++) {
                    Boxes[i][j] = " ";
                }
            }
        }

        private void StartGame() {
            Console.WriteLine(" -- Tic Tac Toe -- ");
            Console.Clear();
        }

        private void WriteBoard() {
            Console.Clear();
            Console.WriteLine(" {0} | {1} | {2} ", Boxes[0][0], Boxes[0][1], Boxes[0][2]);
            Console.WriteLine(" --------- ");
            Console.WriteLine(" {0} | {1} | {2} ", Boxes[1][0], Boxes[1][1], Boxes[1][2]);
            Console.WriteLine(" --------- ");
            Console.WriteLine(" {0} | {1} | {2} ", Boxes[2][0], Boxes[2][1], Boxes[2][2]);
        }

        private Player CheckWin() {
            for (int i = 0; i < Boxes.GetLength(0); i++) {
                if (Boxes[i].All(a => a == Player.X.ToString())) {
                    return Player.X;
                }

                if (Boxes[i].All(a => a == Player.Y.ToString())) {
                    return Player.Y;
                }
            }

            return Player.None;
        }

        private void DisplayLoss() {
            Console.WriteLine();
            Console.WriteLine("No one won.");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}