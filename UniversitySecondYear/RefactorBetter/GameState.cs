using System;

namespace RefactorBetter {
    public class GameState {
        public Player Player { get; private set; }
        public int MoveCount { get; private set; }
        public bool ValueInserted { get; set; }

        public GameState() {
            Player = Player.Y;
            MoveCount = 0;
            ValueInserted = false;
        }

        public void NextTurn() {
            GetNextPlayer();
            MoveCount++;
        }
        public Player GetNextPlayer() {
            switch (Player) {
                case Player.None:
                    throw new ArgumentException();
                case Player.X:
                    Player = Player.Y;
                    return Player;
                case Player.Y:
                    Player = Player.X;
                    return Player;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}


