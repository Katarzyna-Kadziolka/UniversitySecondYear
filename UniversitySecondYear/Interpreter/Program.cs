using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Interpreter{
  
  class Context{
    
    private string input;
    private int output;
  
    public Context(string input){
      this.input = input;
    }
  
    public string Input{
      get { return input; }
      set { input = value; }
    }
  
    public int Output{
      get { return output; }
      set { output = value; }
    }
    
  }
  
  
  abstract class Phrase{
    
    public void Interpreter(Context context){
      
      if (context.Input.Length == 0)
        return;

      if (context.Input.Contains(Nine())) {
        context.Output = context.Output + 9 * Multiplier();
        context.Input = context.Input.Replace(Nine(), "");
      }
      if(context.Input.Contains(Four())) {
        context.Output = context.Output + 4 * Multiplier();
        context.Input = context.Input.Replace(Four(), "");
      }
      if(context.Input.Contains(Five())) {
        if(context.Input.Contains(One())) {
          context.Output = context.Output + 5 * Multiplier() + context.Input.Count(a => a.ToString() == One()) * Multiplier();
          var stringToRemove = Five();
          for (int i = 0; i < context.Input.Count(a => a.ToString() == One()); i++) {
              stringToRemove = stringToRemove + One();
          }
          context.Input = context.Input.Replace(stringToRemove, "");
        }
        else {
          context.Output = context.Output + 5 * Multiplier();
          context.Input = context.Input.Replace(Five(), "");
        }
      }
      if(context.Input.Contains(One())) {
        if(context.Input[0].ToString() == One())
        context.Output = context.Output + context.Input.Count(a => a.ToString() == One()) * Multiplier();
        var stringToRemove = "";
        for (int i = 0; i < context.Input.Count(a => a.ToString() == One()); i++) {
              stringToRemove = stringToRemove + One();
          }
        context.Input = context.Input.Replace(stringToRemove, "");
      }
      
    }
  
    public abstract string One();
    public abstract string Four();
    public abstract string Five();
    public abstract string Nine();
    public abstract int Multiplier();
    
  }
  
  
  class PhraseThousands : Phrase{
    public override string One() { return "M"; }
    public override string Four() { return " "; }
    public override string Five() { return " "; }
    public override string Nine() { return " "; }
    public override int Multiplier() { return 1000; }
  }
  
  class PhraseHundreds : Phrase{
    public override string One() { return "C"; }
    public override string Four() { return "CD"; }
    public override string Five() { return "D"; }
    public override string Nine() { return "CM"; }
    public override int Multiplier() { return 100; }
  }
  
  class PhraseDozens : Phrase{
    public override string One() { return "X"; }
    public override string Four() { return "XL"; }
    public override string Five() { return "L"; }
    public override string Nine() { return "XC"; }
    public override int Multiplier() { return 10; }
  }

  class PhraseUnits: Phrase{
    public override string One() { return "I"; }
    public override string Four() { return "IV"; }
    public override string Five() { return "V"; }
    public override string Nine() { return "IX"; }
    public override int Multiplier() { return 1; }
  }
  //
  //
  //
  
  
  class Apka{
    static void Main(){
  
      List<Phrase> tree = new List<Phrase>();
      tree.Add(new PhraseThousands());
      tree.Add(new PhraseHundreds());
      tree.Add(new PhraseDozens());
      tree.Add(new PhraseUnits());

      var roman = "MDXLIII";
      var context = new Context(roman);
      //
      //
      foreach(Phrase item in tree){
        item.Interpreter(context);
      }
      Console.WriteLine(roman + " = " + context.Output);
      // MDXLIII = 1543
      
      
      roman = "CMXVII";
      context = new Context(roman);
      foreach(Phrase item in tree){
        item.Interpreter(context);
      }
      Console.WriteLine(roman + " = " + context.Output);
      //
      //
      // CMXVII = 917
      
    }
  }
  
}