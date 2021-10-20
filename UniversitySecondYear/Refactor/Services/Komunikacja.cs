using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureLabOne.Services {
    public static class Komunikacja {
        // <summary> 
        // Metoda wyswietla pierwszy komunikat
        // </summary>
        public static void WyswietlKomunikat(string komunikat) {
            var komunikatDoWyswietlenia = $" # {komunikat}";
            Console.WriteLine($"{komunikatDoWyswietlenia}");
        }

        public static void WyswietlKomunikatSystemowy() {
            Console.WriteLine("Witaj! Wprowadź numer indeksu:");
        }
    }
}