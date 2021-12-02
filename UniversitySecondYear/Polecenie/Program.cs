using System;
using System.Text;

public interface IPolecenie{
    void wykonaj();
}

public class KomendaWlacz : IPolecenie {
    Lampa _lampa;
    public KomendaWlacz(Lampa lampa) {
        _lampa = lampa;
    }
    public void wykonaj() {
        _lampa.wlacz();
    }
}

public class KomendaWylacz : IPolecenie {
    Lampa _lampa;
    public KomendaWylacz(Lampa lampa) {
        _lampa = lampa;
    }
    public void wykonaj() {
        _lampa.wylacz();
    }
}
  

public class Lampa{
    public void wylacz(){
        stan = false;
    }

    public void wlacz(){
        stan = true;
    }
    private bool stan = false;
    
    public bool sprawdz(){
        return stan;
    }
}


public class Pilot{
    private IPolecenie _polecenie;
    public void ustawPolecenie(IPolecenie polecenie) {
        _polecenie = polecenie;
    }
    public void wcisnijGuzik() {
        _polecenie.wykonaj();
    }
}


class Program{
    static void Main(string[] args)    {
        Lampa lampa = new Lampa();
        Console.OutputEncoding = Encoding.UTF8;
        IPolecenie wlacz = new KomendaWlacz(lampa);
        IPolecenie wylacz = new KomendaWylacz(lampa);
        Pilot pilot = new Pilot();
        /* UZUPEŁNIĆ */
    
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");
    
        pilot.ustawPolecenie(wlacz);
        pilot.wcisnijGuzik();
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");
    
        pilot.ustawPolecenie(wylacz);
        pilot.wcisnijGuzik();
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");
    
    }
}