using System.Collections.Generic;
namespace PackerTracker.Models
{
  public class Item
  {
    public string Name {get;}
    public int Price {get;}
    public int Weight {get;}
    public bool Purchased {get; set;}
    public bool Packed {get; set;}
    public int Id {get;}
    private static List<Item> _listOfItems = new List<Item>{};
    
    public Item(string name, int price, int weight, bool purchased)
    {
      Name = name;
      Price = price;
      Weight = weight;
      Purchased = purchased;
      Id = _listOfItems.Count;
      _listOfItems.Add(this);
    }

    public static List<Item> GetAllItems()
    {
      return _listOfItems;
    }
    public static Item Find(int id)
    {
      return _listOfItems[id-1];
    }
    public static void DeleteItem(int id)
    {
      _listOfItems.RemoveAt(id);
    }
  }
}