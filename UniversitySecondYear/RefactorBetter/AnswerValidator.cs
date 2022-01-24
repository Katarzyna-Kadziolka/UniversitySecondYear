using System;
using System.Linq;

namespace RefactorBetter {
    public class AnswerValidator : IValidator {
        public string Message { get; set; }
        public bool IsValid { get; set; }
        private int _maxValue;

        public AnswerValidator(int maxValue) {
            _maxValue = maxValue;
        }

        public void Validate(string answer) {
            IsValid = IsNotNullOrEmpty(answer) && IsNumber(answer) && IsLessThanMaxValue(answer);
        }

        private bool IsNotNullOrEmpty(string answer) {
            if (string.IsNullOrEmpty(answer)) {
                Message = "Please, entry a value";
                return false;
            }

            return true;
        }

        private bool IsNumber(string answer) {
            if (answer.All(char.IsDigit)) {
                return true;
            }

            Message = "Input value is not a number!";
            return false;
        }

        private bool IsLessThanMaxValue(string answer) {
            if (Convert.ToInt32(answer) <= _maxValue && Convert.ToInt32(answer) > 0) {
                return true;
            }

            Message = $"Input value should be bigger than 0 and less than {_maxValue + 1}";
            return false;
        }
    }
}