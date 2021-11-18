using System;
using System.Collections.Generic;

namespace Szyfrowanie
{
    class Program
    {
        static void Main(string[] args) {
            var p = 125;
            var q = 325;
            var N = p * q;
            var Q = (p - 1) * (q - 1);
            var e = 0;
            for (int i = 1; i < N; i++) {
                var divisor = GCD((ulong) N, (ulong) i);
                if (divisor == 1) {
                    e = i;
                    break;
                }
            }

            var res = 0;
            var d = 0;
            while (res != 1) {
                d++;
                res = (e * d) % Q;
            }

            Console.WriteLine($"p: {p}");
            Console.WriteLine($"q: {q}");
            Console.WriteLine($"N: {N}");
            Console.WriteLine($"Q: {Q}");
            Console.WriteLine($"e: {e}");
            Console.WriteLine($"d: {d}");

        }

        private static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}

// wymyśl dwe liczby ierwsze (różne od siebie) - p i q 
// N = pq
// NWD(e, N) = 1 (względnie pierwsze
// (e * d) % Q = 1
// Q = (p - 1) (q - 1)
// liczby e to liczby pierwsze - generator liczb pierwszych
