using System;
using System.Linq;

namespace RefactorBetter
{
    public class AnswerValidator
    {
        public string Message { get; private set; }
        private int _maxValue;
        public AnswerValidator(int maxValue) {
            _maxValue = maxValue;
        }
        
        public bool Validate(string answer) {
            return IsNotNullOrEmpty(answer) && IsNumber(answer) && Convert.ToInt32(answer) <= 9;
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
            if (Convert.ToInt32(answer) < _maxValue && Convert.ToInt32(answer) > 0) {
                return true;
            }

            Message = $"Input value cannot be bigger than {_maxValue} and less than 1";
            return false;
        }
    }
}
