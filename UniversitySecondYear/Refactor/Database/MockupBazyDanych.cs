using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArchitectureLabOne.Models;

namespace ArchitectureLabOne.Database
{
    public static class MockupBazyDanych
    {
        public static List<Zajecia> PobierzPlanZajecStudenta(int numerIndeksu) {
            if (numerIndeksu == 1) {
                return new List<Zajecia> {
                    new Zajecia(1, "Kowalstwo", DateTime.Now.AddDays(5), "Mahakam"),
                    new Zajecia(2, "Walka mieczem", DateTime.Now.AddDays(10), "Novigrad"),
                    new Zajecia(3, "Okretownictwo", DateTime.Now.AddDays(12), "Blaviken")
                };
            };
            if (numerIndeksu == 2) {
                return new List<Zajecia> {
                    new Zajecia(1, "Alchemia", DateTime.Now.AddDays(5), "Mahakam"),
                    new Zajecia(2, "Zielarstwo", DateTime.Now.AddDays(10), "Novigrad"),
                    new Zajecia(3, "Rybactwo", DateTime.Now.AddDays(12), "Blaviken")
                };
            }

            if (numerIndeksu == 3) {
                return new List<Zajecia> {
                    new Zajecia(1, "Zaklinanie", DateTime.Now.AddDays(5), "Mahakam"),
                    new Zajecia(2, "Lowiectwo", DateTime.Now.AddDays(10), "Novigrad"),
                    new Zajecia(3, "Tropienie", DateTime.Now.AddDays(12), "Blaviken")
                };
            }
            throw new ArgumentException("Nie ma takiego studenta");
            
        }

        public static Student PobierzDaneStudenta(int numerIndeksu) {
            var listaStudentow = new List<Student> {
                new Student(1, new Osoba(1, "Ola", "Topola"), PobierzPlanZajecStudenta(1) ),
                new Student(2, new Osoba(2, "Stefan", "Stefanski"), PobierzPlanZajecStudenta(2) ),
                new Student(3, new Osoba(3, "Renata", "Cerata"), PobierzPlanZajecStudenta(3) )
                };
            return listaStudentow.FirstOrDefault(a => a.NumerIndeksu == numerIndeksu);
        }
    }
}
