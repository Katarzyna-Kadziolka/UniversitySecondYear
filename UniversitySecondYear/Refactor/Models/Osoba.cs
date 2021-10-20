using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureLabOne.Models
{
    public class Osoba {
        private int _id;
        private string _imie;
        private string _nazwisko;
        public string Inicjaly { get; set; }

        public Osoba(int id, string imie, string nazwisko) {
            _id = id;
            _imie = imie;
            _nazwisko = nazwisko;
            Inicjaly = $"{imie.Substring(0, 1)}. {nazwisko.Substring(0, 1)}.";
        }
    }
}
