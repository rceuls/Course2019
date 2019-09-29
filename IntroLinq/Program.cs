using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroLinq
{
  public class Store
  {
    public string Name { get; set; }
    public List<Stock> Stocks { get; set; }
  }

  public class Stock
  {
    public int Amount { get; set; }
    public Product Product { get; set; }
  }

  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
  public class Program
  {
    static void Main(string[] args)
    {
      var cheese = new Product { Name = "Cheese", Price = 2.5m };
      var bacon = new Product { Name = "Bacon", Price = 3.5m };
      var tomato = new Product { Name = "Tomato", Price = 1.2m };

      // This is called an "object initializer"
      var colruytWieze = new Store
      {
        Name = "De colruyt in Wieze",
        Stocks = new List<Stock>
        {
          new Stock { Product = cheese, Amount = 1 },
          new Stock { Product = bacon, Amount = 2 },
          new Stock { Product = tomato, Amount = 3 }
        }
      };

      var colruytTemse = new Store
      {
        Name = "De colruyt in temse",
        Stocks = new List<Stock> {
          new Stock { Product = cheese, Amount = 1 },
          new Stock { Product = bacon, Amount = 20 },
          new Stock { Product = tomato, Amount = 3 }
        }
      };

      var totalValueInStock = 0.0m;
      foreach (var stock in colruytWieze.Stocks)
      {
        totalValueInStock += stock.Product.Price * stock.Amount;
      }

      Console.WriteLine($"De colruyt in Wieze, totale waarde : {totalValueInStock}");

      totalValueInStock = colruytWieze.Stocks.Sum(x => x.Product.Price * x.Amount);

      Console.WriteLine($"De colruyt in Wieze, totale waarde (linq) : {totalValueInStock}");


      var cheeseValueInStock = 0.0m;
      foreach (var stock in colruytWieze.Stocks)
      {
        if (stock.Product == cheese)
        {
          cheeseValueInStock += stock.Product.Price * stock.Amount;
        }
      }

      Console.WriteLine($"De colruyt in Wieze, totale waarde kaas: {cheeseValueInStock}");

      cheeseValueInStock = colruytWieze.Stocks.Where(x => x.Product == cheese).Sum(x => x.Product.Price * x.Amount);

      Console.WriteLine($"De colruyt in Wieze, totale waarde kaas (linq) : {cheeseValueInStock}");

      var totalValueInStockEverywhere = 0.0m;
      foreach (var stock in colruytWieze.Stocks)
      {
        totalValueInStockEverywhere += stock.Product.Price * stock.Amount;
      }
      foreach (var stock in colruytTemse.Stocks)
      {
        totalValueInStockEverywhere += stock.Product.Price * stock.Amount;
      }

      Console.WriteLine($"De colruyt in Wieze, totale waarde : {totalValueInStockEverywhere}");

      totalValueInStockEverywhere = colruytWieze.Stocks.Union(colruytTemse.Stocks).Sum(x => x.Product.Price * x.Amount);

      Console.WriteLine($"De colruyt in Wieze, totale waarde (linq) : {totalValueInStockEverywhere}");

    }
  }
}
