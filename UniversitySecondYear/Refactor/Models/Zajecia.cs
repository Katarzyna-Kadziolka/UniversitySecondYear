using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureLabOne.Models {
    public class Zajecia {
        private int _id;
        public string Nazwa { get; set; }
        public DateTime Termin { get; set; }
        public string Miejsce { get; set; }

        public Zajecia(int id, string nazwa, DateTime termin, string miejsce) {
            _id = id;
            Nazwa = nazwa;
            Termin = termin;
            Miejsce = miejsce;
        }
        public override string ToString() {
            return $"Nazwa: {Nazwa} \n Termin: {Termin.Date} \n Miejsce: {Miejsce}";
        }
    }
}