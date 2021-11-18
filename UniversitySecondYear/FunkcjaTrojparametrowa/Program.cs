using System;
using System.Numerics;

namespace FunkcjaTrojparametrowa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj N:");
            //var N = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj p");
            //var p = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj L");
            //var l = Convert.ToInt32(Console.ReadLine());

            var N = 55;
            var p = 3;
            
            for (int i = 1; i < N; i++) {
                var c = Count(N, p, i);
                for (int j = 1; j < c; j++) {
                    Console.WriteLine(Count(N, j, c));
                }
            }
        }

        public static BigInteger Count(BigInteger N, int p, BigInteger L) {
            BigInteger power = BigInteger.Pow(L, p);
            return power % N;
        }
    }
}
