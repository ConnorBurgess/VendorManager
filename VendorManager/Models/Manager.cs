using System.Collections.Generic;

namespace VendorManager.Models
{
  abstract public class Manager
  {
    public string Name { get; protected set; }
    public int Id { get; protected set; }
    public string Description { get; protected set; }
    public string Date { get; protected set; }
    public string Price { get; protected set; }

    protected static List<Vendor> VendorInstances = new List<Vendor> { };
    protected static List<Order> OrderInstances = new List<Order> { };
    protected List<Order> CurrentOrdersList = new List<Order> { };
    public static void ClearAll(int i)
    {
      if (i == 1)
      {
        VendorInstances.Clear();
      }
      else if (i == 2)
      {
        OrderInstances.Clear();
      }
    }
  }
}