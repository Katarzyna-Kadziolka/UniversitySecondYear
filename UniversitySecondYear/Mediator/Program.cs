using System;
using System.Collections.Generic;

public interface IMediator {
  void DodajUzytkownika(IUzytkownik uzytkownik);
  void WyslijWiadomosc(string wiadomosc, IUzytkownik nadawca);
}

public class Mediator : IMediator{
    List<IUzytkownik> uzytkownicy;

    public Mediator(){
        uzytkownicy = new List<IUzytkownik>();
    }

    public void DodajUzytkownika(IUzytkownik uzytkownik){
        uzytkownicy.Add(uzytkownik);
    }

    public void WyslijWiadomosc(string wiadomosc, IUzytkownik nadawca){
        foreach(var uzytkownik in uzytkownicy){
          if(uzytkownik != nadawca) {
            uzytkownik.OdbierzWiadomosc(wiadomosc);
          }
        }
    }
}

public interface IUzytkownik {
  void WyslijWiadomosc(string wiadomosc);
  void OdbierzWiadomosc(string wiadomosc);
}

public class Dev : IUzytkownik{
    string login;
    IMediator Mediator;

    public Dev(IMediator Mediator, string login){
        this.login = login;
        this.Mediator = Mediator;
    }

    public void WyslijWiadomosc(string wiadomosc){
        Mediator.WyslijWiadomosc(wiadomosc, this);
    }

    public void OdbierzWiadomosc(string wiadomosc){
        Console.WriteLine("Programista " + login + " otrzymal wiadomosc: " + wiadomosc);
    }
}

public class Uzytkownik : IUzytkownik{
    string login;
    IMediator Mediator;

    public Uzytkownik(IMediator mediator, string login){
        this.login = login;
        this.Mediator = mediator;
    }

    public void WyslijWiadomosc(string wiadomosc){
        Mediator.WyslijWiadomosc(wiadomosc, this);
    }

    public void OdbierzWiadomosc(string wiadomosc){
        Console.WriteLine("Uzytkownik " + login + " otrzymal wiadomosc: " + wiadomosc);
    }
}

class Program{
  static void Main(string[] args){
    
    IMediator mediator = new Mediator();
    
    IUzytkownik ania = new Uzytkownik(mediator, "Ania");
    IUzytkownik nakamoto = new Dev(mediator, "Nakamoto");
    IUzytkownik geohot = new Dev(mediator, "Geohot");
    //
    
    //
    mediator.DodajUzytkownika(nakamoto);
    mediator.DodajUzytkownika(geohot);
    mediator.DodajUzytkownika(ania);
    //
    
    ania.WyslijWiadomosc("Prosze natychmiast wprowadzic poprawki na produkcje.");
    geohot.WyslijWiadomosc("Czekam az Nakamoto zaparzy kawe...");
      
  }
}