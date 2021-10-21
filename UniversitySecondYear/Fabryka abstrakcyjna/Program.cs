using System;
using System.Text;


interface ILitery{
  public string ShowAlfa();
}

interface ICyfry{
  public string ShowNum();
}

class AlfabetFactory{
  
  private SystemFactory _systemFactory;

  public string Numbers { get; set; }
  public string Letters { get; set; }

  public AlfabetFactory(SystemFactory systemFactory){
    _systemFactory = systemFactory;
  }

  public void Generate(){
    Numbers = _systemFactory.CreateNum().ShowNum();
    Letters = _systemFactory.CreateAlfa().ShowAlfa();
  }

}


abstract class SystemFactory{
  public abstract ILitery CreateAlfa();
  public abstract ICyfry CreateNum();
}
    

class GrekaFactory : SystemFactory{
  public override ILitery CreateAlfa(){
    return new GrekaLetters();
  }

  public override ICyfry CreateNum(){
    return new GrekaNumbers();
  }
}

class LacinkaFactory : SystemFactory{
  public override ILitery CreateAlfa(){
    return new LacinkaLetters();
  }

  public override ICyfry CreateNum(){
    return new LacinkaNumbers();
  }
}

class CyrylicaFactory : SystemFactory{
  public override ILitery CreateAlfa(){
    return new CyrylicaLetters();
  }

  public override ICyfry CreateNum(){
    return new CyrylicaNumbers();
  }
}


class LacinkaNumbers: ICyfry{
  string numbers;

  public LacinkaNumbers(){
    numbers = "I II III";
  }  

  public string ShowNum(){
    return numbers;
  }
}

class CyrylicaNumbers : ICyfry{
  string numbers;

  public CyrylicaNumbers(){
    numbers = "1 2 3";
  }  

  public string ShowNum(){
    return numbers;
  }
}


class GrekaNumbers : ICyfry{ 
  string numbers;

  public GrekaNumbers(){
    numbers = "αʹ βʹ γʹ";
  }  

  public string ShowNum(){
    return numbers;
  }
}

class GrekaLetters: ILitery{
  string letters;

  public GrekaLetters(){
    letters = "αβγδε";
  }

  public string ShowAlfa(){
    return letters;
  }
}

class LacinkaLetters : ILitery{
  string letters;

  public LacinkaLetters(){
    letters = "abcde";
  }

  public string ShowAlfa(){
    return letters;
  }
}


class CyrylicaLetters: ILitery{
  string letters;

  public CyrylicaLetters(){
    letters = "абвгд";
  }

  public string ShowAlfa(){
    return letters;
  }
}


public class Application{
    public static void Main(String[] args){
        Console.OutputEncoding = Encoding.UTF8;
      
        AlfabetFactory alfabet_lacinka = new AlfabetFactory(new LacinkaFactory());
        AlfabetFactory alfabet_cyrylica = new AlfabetFactory(new CyrylicaFactory());
        AlfabetFactory alfabet_greka = new AlfabetFactory(new GrekaFactory());

        alfabet_cyrylica.Generate();
        alfabet_greka.Generate();
        alfabet_lacinka.Generate();

        Console.WriteLine($"{alfabet_lacinka.Letters} {alfabet_lacinka.Numbers}");
        Console.WriteLine($"{alfabet_cyrylica.Letters} {alfabet_cyrylica.Numbers}");
        Console.WriteLine($"{alfabet_greka.Letters} {alfabet_greka.Numbers}");

    }
}

  