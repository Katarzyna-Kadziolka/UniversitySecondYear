using System;
using System.Collections.Generic;
using System.Text;

class Zycie{
    private String _czas;

    public void set(String czas) {
        _czas = czas;
        Console.WriteLine($"Skok do roku: {_czas}");
    }

    public Pamiatka zapiszPamiatke() {
        Console.WriteLine("stan zapisany");
        return new Pamiatka (_czas);
    }

    public void przywrocPamiatke(Pamiatka pamiatka) {
        _czas = pamiatka.pobierzCzas();
        Console.WriteLine($"Przywrócono rok: {_czas}");
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
        Console.OutputEncoding = Encoding.UTF8;
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