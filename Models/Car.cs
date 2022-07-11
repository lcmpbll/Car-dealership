using System;

namespace Dealership.Models
{
  public class Car 
  {
    public string MakeModel {get; set; }
    public int Price {get; set; }
    public int Miles {get; set; }
    public double SalePrice {get; set; }
    public double ResalePrice {get; set; }
    
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public void SetSalePrice()
    {
      SalePrice = Price * 0.7;
    }

    public void SetResalePrice()
    {
      ResalePrice = Price * 1.2;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like" + sound;
    }
    
    public Car(string makeModel, int price, int miles, double salePrice, double resalePrice)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      SalePrice = salePrice; 
      ResalePrice = resalePrice;
    }

    public string GetMakeModel() {
      return MakeModel;
    }


    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public double GetSalePrice()
    {
      return SalePrice;
    }

    public double GetResalePrice()
    {
      return ResalePrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}

