using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace CombinationGenerator {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Podaj długość ciągu:");
            //var input = Console.ReadLine();
            //var length = Convert.ToInt32(input);
            var alphabets = new[] {
                'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h',
                'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O',
                'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'w', 'W', 'v', 'V', 'x', 'X', 'y',
                'Y', 'z', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var arrayToCode = new [] { 1, 2, 3 };

            Stopwatch stopwatch = Stopwatch.StartNew();
            //printAllKLength(alphabets, length);
            var newAlphabet = Generate(arrayToCode, numbers);
            //foreach (var c in newAlphabet) {
            //    Console.WriteLine(c);
            //}


            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static bool Generate(int[] arrayToCode, int[] numbers) {
            var myNumbers = numbers.ToList();
            for (int i = 0; i < arrayToCode.Length; i++) {
                var licznik = 0;
                while (licznik != numbers.Length) {
                    var isFull = IsFull(arrayToCode, myNumbers, i);
                    licznik++;
                }

            }

            foreach (var i in arrayToCode) {
                Console.WriteLine(i);
            }
            
            return true;
        }

        public static bool IsFull(int[] arrayToCode, List<int> myNumbers, int index) {
            var num = myNumbers.FindIndex(a => a == arrayToCode[index]);
            arrayToCode[index] = num;
            return false;
        }

        //static void printAllKLength(char[] alphabet, int combinationLength) {
        //    int alphabetLength = alphabet.Length;
        //    printAllKLengthRec(alphabet, "", alphabetLength, combinationLength);
        //}

        //static void printAllKLengthRec(char[] alphabet,
        //    String prefix,
        //    int alphabetLength, int combinationLength) {
        //    if (combinationLength == 0) {
        //        //Console.WriteLine(prefix);
        //        return;
        //    }

        //    for (int i = 0; i < alphabetLength; ++i) {
        //        String newPrefix = prefix + alphabet[i];

        //        printAllKLengthRec(alphabet, newPrefix,
        //            alphabetLength, combinationLength - 1);
        //    }
        //}
    }
}

// program do szyfrowania
// wczytuje tekst wypisuje każ☺dą litere zakodowaną jako liczba hex ale pomiędzy są spacje
// parametry: 3 liczby całkowite
// wypisuej czwartą liczbę całkowitą