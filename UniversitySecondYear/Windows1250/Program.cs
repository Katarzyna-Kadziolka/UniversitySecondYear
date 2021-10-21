using System;
using System.Collections.Immutable;
using System.Linq;

namespace CeasarCodeSimple
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // litery małe, duże, cyfry
            var alphabets = new [] { 'a', 'A', 'ą', 'Ą', 'b', 'B', 'c', 'C', 'ć', 'Ć', 'd', 'D', 'e', 'E', 'ę', 'Ę', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'ł', 'Ł', 'm', 'M', 'n', 'N', 'ń', 'Ń', 'o', 'O', 'ó', 'Ó', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 'ś', 'Ś', 't', 'T', 'u', 'U', 'w', 'W', 'v', 'V', 'x', 'X', 'y', 'Y', 'z', 'Z', 'ź', 'Ź', 'ż', 'Ż', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            while (true) {
                Console.WriteLine("Podaj przesunięcie: ");
                var shift = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj teks do zaszyfrowania: ");
                var text = Console.ReadLine().ToCharArray();
                var code = new char[text.Length];
                var alphabetList = alphabets.ToList();
                for (int i = 0; i < text.Length; i++) {
                    var positionOfLetter = alphabetList.IndexOf(text[i]);
                    var newIndex = positionOfLetter + shift;
                    code[i] = alphabets[newIndex % alphabets.Length];
                }

                foreach (var c in code) {
                    Console.Write(c);
                }

            }
        }
    }
}

// odwrotny cezar, nie znam klucza
// porównujemy z plikiem zawierającym słowa

