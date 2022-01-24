using System;

namespace RefactorBetter {
    public class NotVacantException : Exception {
        public NotVacantException(string boxNumber) : base($"Box number {boxNumber} is already full") { }
    }
}