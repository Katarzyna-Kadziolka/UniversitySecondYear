namespace RefactorBetter {
    public interface IBoard {
        public string[][] Boxes { get; set; }
        public void WriteBoard();
        public void SetValue(string answer, string symbol);
        public bool LineIsFull(string symbol);
    }
}