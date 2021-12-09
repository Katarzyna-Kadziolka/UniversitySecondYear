using System;
using System.Collections.Generic;

class Zycie{
    private String _czas;

    public void set(String czas) {
        _czas = czas;
    }

    public Pamiatka zapiszPamiatke() {
        return new Pamiatka (_czas);
    }

    public void przywrocPamiatke(Pamiatka pamiatka) {
        _czas = pamiatka.pobierzCzas();
    }

    public class Pamiatka {
        private String _czas;

        public Pamiatka(String czas) {
            _czas = czas;
        }

        public String pobierzCzas() {
            return _czas;
        }
    }
}
 

class MainClass{
    public static void Main (string[] args){
    
        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
        Console.WriteLine();
    
        List<Zycie.Pamiatka> zapisaneStany = new List<Zycie.Pamiatka>();
        Zycie zycie = new Zycie();

        zycie.set("1985");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1955");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("2015");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1885");

        zycie.przywrocPamiatke(zapisaneStany[0]);   

    }
}