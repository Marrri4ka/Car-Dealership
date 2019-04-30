using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult CarsIndex()
    {
      List<Car> allCars= Car.GetAll();
      return View(allCars);
    }
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost ("/cars")]
    public ActionResult Create (string makeModel, int price, int miles, string message)
    {
      Car myCar= new Car(makeModel,price,miles,message);
      return RedirectToAction("CarsIndex");
    }

    [HttpGet ("/cars/checkprice")]
    public ActionResult PriceForm()
    {
    return View();
    }

    [HttpPost ("/cars/showmatchedcars")]
    public ActionResult ShowCars(int Price)
    {
      List<Car> allCars= Car.GetAll();
      List<Car> newList = new List<Car>();
      foreach (Car car in allCars)
      {
        if(Price > @car.GetPrice())
        {
          newList.Add(car);
        }
      }

    return View("CarsIndex",newList);
    }

  }
}
