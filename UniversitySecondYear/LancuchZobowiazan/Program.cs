using System;
using System.Text;

public interface Lancuch{
    void ustawNastepne(Lancuch c);
    void przetwarzaj(Powiadomienia powiadomienia);
}
 
public class Powiadomienia{
  
    private int number;
  
    public Powiadomienia(int number){
        this.number = number;
    }
  
    public int pobierzLiczbe(){
        return number;
    }
 
}
 
public class BrakLancuch : Lancuch{
  
    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c){
        nastepneWLancuchu = c;
    }

    public void przetwarzaj(Powiadomienia powiadomienia){
        if (powiadomienia.pobierzLiczbe() <= 0){
            Console.WriteLine("Brak powiadomień");
        }else{
            ustawNastepne(new MaloPowiadomienLancuch());
            nastepneWLancuchu.przetwarzaj(powiadomienia);
        }
    }
}

public class MaloPowiadomienLancuch : Lancuch{
  
    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c){
        nastepneWLancuchu = c;
    }

    public void przetwarzaj(Powiadomienia powiadomienia){
        if (powiadomienia.pobierzLiczbe() <= 5){
            Console.WriteLine($"Mało powiadomień: {powiadomienia.pobierzLiczbe()}");
        }else{
            ustawNastepne(new DuzoPowiadomienLancuch());
            nastepneWLancuchu.przetwarzaj(powiadomienia);
        }
    }
}

public class DuzoPowiadomienLancuch : Lancuch{
  
    public void ustawNastepne(Lancuch c){}

    public void przetwarzaj(Powiadomienia powiadomienia){
        Console.WriteLine($"Dużo powiadomień: {powiadomienia.pobierzLiczbe()}");
    }
}

 
class Program{
    static void Main(String[] args){
        Console.OutputEncoding = Encoding.UTF8;
        Lancuch l1 = new BrakLancuch();

        int i =  0;
        l1.przetwarzaj(new Powiadomienia(i));
        i++;
        l1.przetwarzaj(new Powiadomienia(i));
        i = i + 11;
        l1.przetwarzaj(new Powiadomienia(i));
        i = i - 9;
        l1.przetwarzaj(new Powiadomienia(i));
        i = i - 3;
        l1.przetwarzaj(new Powiadomienia(0));
    
    }
}