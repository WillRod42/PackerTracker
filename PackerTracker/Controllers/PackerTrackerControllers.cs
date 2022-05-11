using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> itemsList = Item.GetAllItems();
      return View(itemsList);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, int price, int weight, bool purchased)
    {
      {
        Item newItem = new Item(name, price, weight, purchased);
        return RedirectToAction("Index");
      }
    }
    [HttpPost("/items/{id}")]
    public ActionResult Delete(int id)
    {
      Item.DeleteItem(id);
      return RedirectToAction("Index");
    }
  }
  
}