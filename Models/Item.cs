using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public static List<Item> _instances = new List<Item> {};
    private string _item;
    private string _date;
    private string _description;
    private string _importance;
    private int _id;


    public Item(string item, string date = "0", string description = "null", string importance = "null")
      {
        _item = item;
        _date = date;
        _description = description;
        _importance = importance;
        _id = _instances.Count;
      }

    public string GetItem()
    {
      return _item;
    }

    public void SetItem(string newItem)
    {
      _item = newItem;
    }

    public string GetDate()
    {
      return _date;
    }

    public void SetDate(string newDate)
    {
      _date = newDate;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetImportance()
    {
      return _importance;
    }

    public void SetImportance(string newImportance)
    {
      _importance = newImportance;
    }

    public int GetId()
    {
      return _id + 1;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
