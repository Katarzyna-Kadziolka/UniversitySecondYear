namespace RefactorBetter {
    public interface IValidator {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public void Validate(string answer);
    }
}