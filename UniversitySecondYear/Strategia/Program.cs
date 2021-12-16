using System;

public abstract class Zawodnik{
  
    KopniecieTyp _kopniecieTyp;
    SkokTyp _skokTyp;
 
    public Zawodnik(KopniecieTyp kopniecieTyp, SkokTyp skokTyp){
        _kopniecieTyp = kopniecieTyp;
        _skokTyp = skokTyp;
    }
    
    public void uderzenie(){
        Console.WriteLine("Uderzenie");
    }
    
    public void kopniecie(){
        _kopniecieTyp.kopniecie();
    }
    
    public void skok(){
        _skokTyp.skok();
    }
    
    public void ustawKopniecieTyp(KopniecieTyp kopniecieTyp){
        _kopniecieTyp = kopniecieTyp;
    }
    
    public void ustawSkokTyp(SkokTyp skokTyp){
        _skokTyp = skokTyp;
    }
    
    public abstract void przedstaw();
    /* UZUPEŁNIĆ */
    
}
 
 
public interface KopniecieTyp{
  
  void kopniecie();
  
}


public class KopniecieLod : KopniecieTyp{
  
  public void kopniecie() {
    Console.WriteLine("Kopniecie lodowe");
  }
  
}

public class KopniecieOgien : KopniecieTyp{
  public void kopniecie() {
    Console.WriteLine("Kopniecie z ogniem");
  }
}

 
public interface SkokTyp{
  
  void skok();
  
}

public class KrotkiSkok : SkokTyp{
  
  public void skok() {
    Console.WriteLine("Krotki skok");
  }
}

public class DlugiSkok : SkokTyp{
  
  public void skok() {
    Console.WriteLine("Dlugi skok");
  }
}
 
 
public class SubZero : Zawodnik{
  
  public SubZero (KopniecieTyp kopniecieTyp, SkokTyp skokTyp) : base (kopniecieTyp, skokTyp) {}
  
  
  override public void przedstaw(){
    Console.WriteLine("Jestem Sub-Zero!");
  }
  
}

public class Scorpion : Zawodnik{
  
  public Scorpion (KopniecieTyp kopniecieTyp, SkokTyp skokTyp) : base (kopniecieTyp, skokTyp) {}
  
  
  override public void przedstaw(){
    Console.WriteLine("Jestem Scorpion!");
  }
  
}


class MainClass {
  
  public static void Main (string[] args) {
    Console.WriteLine("-- Mortal Kombat --");
    Console.WriteLine();
    
    var krotkiSkok = new KrotkiSkok();
    var dlugiSkok = new DlugiSkok();
    KopniecieTyp kopniecieLod = new KopniecieLod();
    KopniecieTyp kopniecieOgien = new KopniecieOgien();


    Zawodnik subZero = new SubZero(kopniecieLod, krotkiSkok);
    subZero.przedstaw();
    subZero.uderzenie();
    subZero.kopniecie();
    subZero.skok();
    subZero.ustawSkokTyp(dlugiSkok);
    subZero.skok();
    
    Console.WriteLine();

    var scorpion = new Scorpion(kopniecieOgien, dlugiSkok);
    scorpion.przedstaw();
    scorpion.uderzenie();
    scorpion.kopniecie();
    scorpion.ustawKopniecieTyp(kopniecieLod);
    scorpion.kopniecie();
    scorpion.skok();
    
  }
  
}