using System;

namespace RefactorBetter {
    public class GameState {
        public Player Player { get; private set; } = Player.Y;
        public int MoveCount { get; private set; } 
        public bool ValueInserted { get; set; }
        public int MaxValue { get; }

        public GameState(int maxValue) {
            MaxValue = maxValue;
        }

        public void NextTurn() {
            GetNextPlayer();
            MoveCount++;
        }
        public void GetNextPlayer() {
            switch (Player) {
                case Player.None:
                    throw new ArgumentException();
                case Player.X:
                    Player = Player.Y;
                    return;
                case Player.Y:
                    Player = Player.X;
                    return;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}


