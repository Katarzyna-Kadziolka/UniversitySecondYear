using System;
using System.Collections.Generic;
using System.Linq;


public abstract class ProductPrototype
{
  
    public decimal Price { get; set; }

    public ProductPrototype(decimal price)
    {
        Price = price;
    }

    public ProductPrototype Clone(){
        return (ProductPrototype) this.MemberwiseClone();
    }
  
}


public class Bread : ProductPrototype
{
  
    public Bread(decimal price) : base(price){}

}


public class Butter : ProductPrototype
{
    public Butter(decimal price) : base(price){}
}


public class Supermarket
{
  
    private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key)
    {
        return _productList[key].Clone();
    }
  
}


class MainClass 
{
    public static void Main (string[] args) 
    {
    
        //... supermarket
        var supermarket = new Supermarket();
        //... product; 
        supermarket.AddProduct("Bread", new Bread(9.50m));
        //...
        supermarket.AddProduct("Butter", new Butter(5.30m));
      
      
        //...
        var products = new List<ProductPrototype>();
        products.Add(supermarket.GetClonedProduct("Bread"));
        products.Add(supermarket.GetClonedProduct("Bread"));
        products.Add(supermarket.GetClonedProduct("Butter"));
        var wasBread = false;

        foreach (var product in products) {
            if (!wasBread && product.GetType() == typeof(Bread)) {
                Console.WriteLine($"Bread - {product.Price} zł > {product.Price - product.Price * 0.1m:0.00} zł");
                wasBread = true;

            }
            else if (product.GetType() == typeof(Bread)) {
                Console.WriteLine(String.Format("Bread - {0} zł", product.Price));
            }
            else {
                Console.WriteLine(String.Format("Butter - {0} zł", product.Price));
            }
            
        }

        
        //...
      
    }
}