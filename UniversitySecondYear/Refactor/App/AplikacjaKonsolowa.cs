using System;
using ArchitectureLabOne.Database;
using ArchitectureLabOne.Services;

namespace ArchitectureLabOne.App {
    public class AplikacjaKonsolowa {
        static void Main(string[] args) {
            const string domyslnyKomunikatPowitalny = "Witaj! Wprowadź numer indeksu:";
            while (true) {
                Komunikacja.WyswietlKomunikat(domyslnyKomunikatPowitalny);
                var input = Console.ReadLine();
                try {
                    var index = Convert.ToInt32(input);
                    var zajecia = MockupBazyDanych.PobierzPlanZajecStudenta(index);

                    Console.WriteLine($"{MockupBazyDanych.PobierzDaneStudenta(index).Osoba.Inicjaly}:");
                    foreach (var zajecie in zajecia) {
                        Console.WriteLine(zajecie.ToString());
                    }


                    Console.WriteLine();
                }
                catch (ArgumentException e) {
                    Console.WriteLine("Nie ma takiego studenta");
                    Console.WriteLine();
                }
                catch (Exception e) {
                    Console.WriteLine("Numer indeksu musi być liczbą");
                    Console.WriteLine();
                }
            }
        }
    }
}