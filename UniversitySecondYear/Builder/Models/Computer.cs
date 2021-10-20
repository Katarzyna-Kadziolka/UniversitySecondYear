using System;

namespace ArchotekturaLabTwo.Models {
    public class Computer {
        private string _type;
        public string MotherBoard { get; set; }
        public double Price { get; set; }
        public string Screen { get; set; }
        public string Processor { get; set; }
        public string Drive { get; set; }

        public Computer(string computerType) {
            _type = computerType;
            Price = 0;
        }

        public void DisplayConfiguration() {
            Console.WriteLine("Typ: " + _type);
            Console.WriteLine("Płyta główna: " + MotherBoard);
            Console.WriteLine("Procesor: " + Processor);
            Console.WriteLine("Dysk: " + Drive);
            Console.WriteLine("Monitor: " + Screen);
            Console.WriteLine("Cena: " + $"{Price:0.00}");
        }
    }
}