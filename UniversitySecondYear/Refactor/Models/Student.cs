using System;
using System.Collections.Generic;
using System.Text;
using ArchitectureLabOne.Database;

namespace ArchitectureLabOne.Models {
    public class Student {
        public int NumerIndeksu;
        public Osoba Osoba { get; set; }
        public List<Zajecia> PlanZajec { get; set; }

        public Student(int numerIndeksu, Osoba osoba, List<Zajecia> planZajec) {
            NumerIndeksu = numerIndeksu;
            Osoba = osoba;
            PlanZajec = planZajec;
        }

        public List<Zajecia> PobierzPlanZajec() {
            return MockupBazyDanych.PobierzPlanZajecStudenta(NumerIndeksu);
        }
    }
}