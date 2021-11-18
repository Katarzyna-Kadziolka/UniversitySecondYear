using System;
using System.Collections.Generic;
using System.Text;

public interface Kompozyt{
  string nazwa { get; set;}
  void DodajElement(Kompozyt element);
  void UsunElement(Kompozyt element);
  void Renderuj();
}

public class Lisc : Kompozyt{
  
  public string nazwa { get; set; }

  public void Renderuj(){
    Console.WriteLine( nazwa + " renderowanie...");
  }

  public Lisc () {

  }
  // konstruktor
  
  public void DodajElement(Kompozyt kompozyt) {
    Console.WriteLine("Liść nie może dodawać elementów");
  }
  // 2 brakujące metody których wymaga 
  public void UsunElement(Kompozyt kompozyt)  {
    Console.WriteLine("Liść nie może usuwać elementów");
  }

}


public class Wezel : Kompozyt{

  private List<Kompozyt> Lista=new List<Kompozyt>();

  public string nazwa { get; set; }

  public void Renderuj(){
    Console.WriteLine($"{nazwa} rozpoczęcie renderowania");
    //rozpoczęcie renderowania
    foreach (var item in Lista) {
      item.Renderuj();
    }
    //foreach item.Renderuj(); 
    Console.WriteLine($"{nazwa} zakończenie renderowania");
    //zakończenie renderowania
  }

  public void DodajElement(Kompozyt kompozyt) {
    Lista.Add(kompozyt);
  }
  public void UsunElement(Kompozyt kompozyt) {
    Lista.Remove(kompozyt);
  }
  // 2 brakujące metody 
  
}


class MainClass {
  public static void Main (string[] args) {
    Console.OutputEncoding = Encoding.UTF8;

    Wezel korzen = new Wezel();
    korzen.nazwa = "Korzeń";
    Lisc lisc11 = new Lisc();
    lisc11.nazwa = "Liść 1.1";
    korzen.DodajElement(lisc11);
    
    Wezel wezel2 = new Wezel();
    wezel2.nazwa = "Węzeł 2";
    korzen.DodajElement(wezel2);
    Lisc lisc21 = new Lisc();
    lisc21.nazwa = "Liść 2.1";
    wezel2.DodajElement(lisc21);
    Lisc lisc22 = new Lisc();
    lisc22.nazwa = "Liść 2.2";
    wezel2.DodajElement(lisc22);
    Lisc lisc23 = new Lisc();
    lisc23.nazwa = "Liść 2.3";
    wezel2.DodajElement(lisc23);
    
    Wezel wezel3 = new Wezel();
    wezel3.nazwa = "Węzeł 3"; 
    wezel2.DodajElement(wezel3);
    Lisc lisc31 = new Lisc();
    lisc31.nazwa = "Liść 3.1";
    wezel3.DodajElement(lisc31);
    Lisc lisc32 = new Lisc();
    lisc32.nazwa = "Liść 3.2";
    wezel3.DodajElement(lisc32);

    Wezel wezel33 = new Wezel();
    wezel33.nazwa = "Węzeł 3.3"; 
    wezel3.DodajElement(wezel3);
    Lisc lisc331 = new Lisc();
    lisc331.nazwa = "Liść 3.3.1";
    wezel33.DodajElement(lisc331);

    
    korzen.Renderuj();
    
  }
}