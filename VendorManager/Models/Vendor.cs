using System.Collections.Generic;
namespace VendorManager.Models
{
  public class Vendor : Manager
  {
    public static List<Vendor> VendorInstances = new List<Vendor> { };
    public List<Order> CurrentOrdersList = new List<Order> { };
    public Vendor(string name, string description)
    {
      this.Name = name;
      Description = description;
      VendorInstances.Add(this);
      Id = VendorInstances.Count;

    }
    public static List<Vendor> GetVendors()
    {
      return VendorInstances;
    }
    public List<Order> GetOrders()
    {
      return CurrentOrdersList;
    }

    public static Vendor FindVendors(int searchId)
    {
      return VendorInstances[searchId - 1];
    }
    public void AddOrder(Order order)
    {
      CurrentOrdersList.Add(order);
    }
    public static void ClearAll()
    {
      VendorInstances.Clear();
    }
  }
}
