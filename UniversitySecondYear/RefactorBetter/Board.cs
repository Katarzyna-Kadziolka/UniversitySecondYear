using System;
using System.Linq;

namespace RefactorBetter {
    public class Board : IBoard {
        public string[][] Boxes { get; set; }

        public Board() {
            Boxes = new string[3][];
            for (int i = 0; i < Boxes.Length; i++) {
                Boxes[i] = new string[3];
                for (int j = 0; j < Boxes[i].Length; j++) {
                    Boxes[i][j] = " ";
                }
            }
        }

        public void WriteBoard() {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" {0} | {1} | {2} ", Boxes[0][0], Boxes[0][1], Boxes[0][2]);
            Console.WriteLine(" --------- ");
            Console.WriteLine(" {0} | {1} | {2} ", Boxes[1][0], Boxes[1][1], Boxes[1][2]);
            Console.WriteLine(" --------- ");
            Console.WriteLine(" {0} | {1} | {2} ", Boxes[2][0], Boxes[2][1], Boxes[2][2]);
        }

        public void SetValue(string answer, string symbol) {
            var isNotEmpty = true;
            while (isNotEmpty) {
                var boxNumber = 0;
                foreach (var box in Boxes) {
                    for (int j = 0; j < box.Length; j++) {
                        boxNumber++;
                        if (boxNumber == Convert.ToInt32(answer)) {
                            if (box[j] == " ") {
                                box[j] = symbol;
                                isNotEmpty = false;
                            }
                            else {
                                throw new NotVacantException(answer);
                            }
                        }
                    }
                }
            }
        }

        public bool LineIsFull(string symbol) {
            return AnyHorizontalLine(symbol) || AnyVerticalLine(symbol) || IsCrossLineLeftToRightFull(symbol) ||
                   IsCrossLineRightToLeftFull(symbol);
        }

        private bool IsCrossLineRightToLeftFull(string symbol) {
            for (int i = 0; i < Boxes.GetLength(0); i++) {
                for (int j = 0; j < Boxes.GetLength(0); j++) {
                    if (j == Boxes.GetLength(0) - 1 - i) {
                        if (Boxes[i][j] != symbol) {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private bool IsCrossLineLeftToRightFull(string symbol) {
            for (int i = 0; i < Boxes.GetLength(0); i++) {
                for (int j = 0; j < Boxes.GetLength(0); j++) {
                    if (i == j) {
                        if (Boxes[j][i] != symbol) {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private bool AnyHorizontalLine(string symbol) {
            for (int i = 0; i < Boxes.GetLength(0); i++) {
                if (Boxes[i].All(a => a == symbol)) {
                    return true;
                }
            }

            return false;
        }

        private bool AnyVerticalLine(string symbol) {
            for (int i = 0; i < Boxes.GetLength(0); i++) {
                for (int j = 0; j < Boxes.GetLength(0); j++) {
                    if (Boxes[j][i] != symbol) {
                        break;
                    }

                    if (j == Boxes.GetLength(0) - 1) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}