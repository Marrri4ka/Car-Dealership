using System.Collections.Generic;

namespace Dealership.Models {

  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Message;
    private static List<Car> cars = new List<Car>{};

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      cars.Add(this);
    }

    public static List<Car> GetAll()
    {
      return cars;
    }

    public static void ClearAll()
    {
      cars.Clear();
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public void SetMakeModel(string newModel)
    {
       MakeModel = newModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public void SetPrice (int newPrice)
    {
      Price = newPrice;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public void SetMiles(int newMiles)
    {
      Miles = newMiles;
    }
    public string GetMessage()
    {
      return Message;
    }

    public void SetMessage(string newMessage)
    {
       Message = newMessage;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public bool UnderMile(int maxMiles)
    {
      return (Miles < maxMiles);
    }
  }

}
