using System;

namespace RefactorBetter {
    public class Game : IGame {
        
        private readonly GameState _gameState;
        private IValidator _validator;
        private IDisplay _display;
        private IBoard _board;

        public Game(IBoard board, GameState gameState, IValidator validator, IDisplay display) {
            _board = board;
            _gameState = gameState;
            _validator = validator;
            _display = display;
        }

        public void Play() {
            _display.DisplayStartGameView();
            while (!_board.LineIsFull(_gameState.Player.ToString())) {
                if (_gameState.MoveCount == 9) {
                    _board.WriteBoard();
                    _display.DisplayLoss();
                }

                _gameState.NextTurn();
                do {
                    _board.WriteBoard();
                    _display.AskForAnswer(_gameState.Player);
                    var answer = Console.ReadLine();
                    Validate(answer);
                } while (!_gameState.ValueInserted);
            }
            _board.WriteBoard();
            _display.DisplayWinner(_gameState.Player);
        }

        private void Validate(string answer) {
            _validator.Validate(answer);
            if (_validator.IsValid) {
                try {
                    _gameState.ValueInserted = true;
                    _board.SetValue(answer, _gameState.Player.ToString());
                }
                catch (NotVacantException e) {
                    _gameState.ValueInserted = false;
                    _display.DisplayError(e.Message);
                }
            }
            else {
                _gameState.ValueInserted = false;
                _display.DisplayError(_validator.Message);
            }
        }
    }
}